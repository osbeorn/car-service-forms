using CarServiceForms.Classes;
using CarServiceForms.Core.Collections;
using CarServiceForms.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class ExtendedServiceSelectionForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }
        private WorkOrder WorkOrder { get; set; }

        private bool Initializing { get; set; }

        public ExtendedServiceSelectionForm(long workOrderId)
        {
            InitializeComponent();
            InitializeComponents(workOrderId);
        }

        private void InitializeComponents(long workOrderId)
        {
            DBContext = new CarServiceFormsDBContext();

            SetupListViews();
            SetupServiceTypeComboBoxDatasource();

            GetWorkOrderData(workOrderId);
        }

        public void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void GetWorkOrderData(long workOrderId)
        {
            WorkOrder = DBContext.WorkOrder.Find(workOrderId);
            if (WorkOrder.Service != null)
            {
                deleteButton.Enabled = true;

                PresetListViews();
            }
            else
            {
                serviceTypeComboBox.SelectedIndexChanged += ServiceTypeComboBox_SelectedIndexChanged;
                ServiceTypeComboBox_SelectedIndexChanged(serviceTypeComboBox, null);
            }
        }

        private void SetupListViews()
        {
            leftListView.ListViewItemSorter = new ListViewItemComparer();
            rightListView.ListViewItemSorter = new ListViewItemComparer();
        }

        private void SetupServiceTypeComboBoxDatasource()
        {
            serviceTypeComboBox.SelectedIndexChanged -= ServiceTypeComboBox_SelectedIndexChanged;

            var serviceTypes = DBContext.ServiceType
                .Where(st => st.Active && !st.Deleted)
                .ToList();
            serviceTypeComboBox.DataSource = serviceTypes;
        }

        private void PresetListViews()
        {
            serviceTypeComboBox.Enabled = false;
            transferLeftButton.Enabled = false;
            transferRightButton.Enabled = false;

            serviceTypeComboBox.SelectedValue = WorkOrder.Service.ServiceType.Id;

            var appliedServiceItemIds = WorkOrder.Service.AppliedServiceItems
                .Select(asi => asi.ServiceItem.Id)
                .ToList();

            var serviceItemGroups = DBContext.ServiceItem
                .Where(si =>
                    appliedServiceItemIds.Contains(si.Id) &&
                    si.Active &&
                    !si.Deleted &&
                    si.ServiceItemGroup.Active &&
                    !si.ServiceItemGroup.Deleted
                )
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Name = si.Name,
                        Order = si.Order,
                        HasRemarks = si.HasRemarks,
                        ServiceItemGroupId = si.ServiceItemGroup.Id,
                        ServiceItemGroupName = si.ServiceItemGroup.Name,
                        ServiceItemGroupOrder = si.ServiceItemGroup.Order
                    }
                )
                .OrderBy(si => si.ServiceItemGroupOrder)
                .ThenBy(si => si.Order)
                .GroupBy(si => si.ServiceItemGroupId)
                .ToList();

            var remainingServiceItemGroups = DBContext.ServiceItem
                .Where(si =>
                    !appliedServiceItemIds.Contains(si.Id) &&
                    si.Active &&
                    !si.Deleted &&
                    si.ServiceItemGroup.Active &&
                    !si.ServiceItemGroup.Deleted
                )
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Name = si.Name,
                        Order = si.Order,
                        HasRemarks = si.HasRemarks,
                        ServiceItemGroupId = si.ServiceItemGroup.Id,
                        ServiceItemGroupName = si.ServiceItemGroup.Name,
                        ServiceItemGroupOrder = si.ServiceItemGroup.Order
                    }
                )
                .OrderBy(si => si.ServiceItemGroupOrder)
                .ThenBy(si => si.Order)
                .GroupBy(si => si.ServiceItemGroupId)
                .ToList();

            ClearListView(leftListView);
            ClearListView(rightListView);

            SetupListViewItems(remainingServiceItemGroups, leftListView);
            SetupListViewItems(serviceItemGroups, rightListView);
        }

        private void ServiceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedServiceTypeId = (long) serviceTypeComboBox.SelectedValue;

            var serviceItemGroups = DBContext.ServiceItem
                .Where(si => 
                    si.ServiceItemGroup.ServiceType.Id == selectedServiceTypeId &&
                    si.Active &&
                    !si.Deleted &&
                    si.ServiceItemGroup.Active &&
                    !si.ServiceItemGroup.Deleted
                )
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Name = si.Name,
                        Order = si.Order,
                        HasRemarks = si.HasRemarks,
                        ServiceItemGroupId = si.ServiceItemGroup.Id,
                        ServiceItemGroupName = si.ServiceItemGroup.Name,
                        ServiceItemGroupOrder = si.ServiceItemGroup.Order
                    }
                )
                .OrderBy(si => si.ServiceItemGroupOrder)
                .ThenBy(si => si.Order)
                .GroupBy(si => si.ServiceItemGroupId)
                .ToList();

            var remainingServiceItemGroups = DBContext.ServiceItem
                .Where(si => 
                    si.ServiceItemGroup.ServiceType.Id != selectedServiceTypeId &&
                    si.Active &&
                    !si.Deleted &&
                    si.ServiceItemGroup.Active &&
                    !si.ServiceItemGroup.Deleted
                )
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Name = si.Name,
                        Order = si.Order,
                        HasRemarks = si.HasRemarks,
                        ServiceItemGroupId = si.ServiceItemGroup.Id,
                        ServiceItemGroupName = si.ServiceItemGroup.Name,
                        ServiceItemGroupOrder = si.ServiceItemGroup.Order
                    }
                )
                .OrderBy(si => si.ServiceItemGroupOrder)
                .ThenBy(si => si.Order)
                .GroupBy(si => si.ServiceItemGroupId)
                .ToList();

            ClearListView(leftListView);
            ClearListView(rightListView);

            SetupListViewItems(remainingServiceItemGroups, leftListView);
            SetupListViewItems(serviceItemGroups, rightListView);
        }

        private void ClearListView(ListView listView)
        {
            listView.Groups.Clear();
            listView.Items.Clear();
        }

        private void SetupListViewItems(List<IGrouping<long, ServiceItemWithServiceItemGroupDTO>> groups, ListView listView)
        {
            foreach (var entry in groups)
            {
                var items = entry.ToList();
                if (items.Count == 0)
                {
                    continue;
                }

                var group = items[0];
                var listViewGroup = new ListViewGroup()
                {
                    Tag = group,
                    Header = group.ServiceItemGroupName
                };
                listView.Groups.Add(listViewGroup);

                foreach (var item in items)
                {
                    var listViewItem = new ListViewItem()
                    {
                        Tag = item,
                        Text = item.Name,
                        ToolTipText = item.Name,
                        Group = listViewGroup,
                    };
                    listView.Items.Add(listViewItem);
                }
            }
        }

        private void TransferLeftButton_Click(object sender, EventArgs e)
        {
            TransferItemsBetweenListViews(rightListView, leftListView);
        }

        private void TransferRightButton_Click(object sender, EventArgs e)
        {
            TransferItemsBetweenListViews(leftListView, rightListView);
        }

        private void TransferItemsBetweenListViews(ListView sourceListView, ListView destinationListView)
        {
            if (sourceListView.SelectedItems.Count == 0)
            {
                return;
            }

            sourceListView.BeginUpdate();
            destinationListView.BeginUpdate();

            foreach (ListViewItem sourceListViewItem in sourceListView.SelectedItems)
            {
                sourceListViewItem.Selected = false;
                sourceListViewItem.Focused = false;

                var sourceServiceItemDTO = sourceListViewItem.Tag as ServiceItemWithServiceItemGroupDTO;

                ListViewGroup foundDestinationListViewGroup = null;
                foreach (ListViewGroup destinationListItemGroup in destinationListView.Groups)
                {
                    var destinationServiceItemGroupDTO = destinationListItemGroup.Tag as ServiceItemWithServiceItemGroupDTO;

                    if (destinationServiceItemGroupDTO.ServiceItemGroupId == sourceServiceItemDTO.ServiceItemGroupId)
                    {
                        foundDestinationListViewGroup = destinationListItemGroup;
                        break;
                    }
                }

                if (foundDestinationListViewGroup != null) // group found
                {
                    InsertListViewItemInExistingListViewGroup(foundDestinationListViewGroup, sourceListViewItem);
                }
                else // new group
                {
                    InsertListViewItemInNewGroup(destinationListView, sourceListViewItem);
                }
            }
            
            sourceListView.EndUpdate();
            destinationListView.EndUpdate();

            sourceListView.SelectedIndices.Clear();
            sourceListView.SelectedItems.Clear();

            destinationListView.SelectedIndices.Clear();
            destinationListView.SelectedItems.Clear();

            SortListViewGroups(destinationListView);
        }

        private void InsertListViewItemInExistingListViewGroup(ListViewGroup destinationListViewGroup, ListViewItem sourceListViewItem)
        {
            // remove from previous list view
            var sourceListViewGroup = sourceListViewItem.Group;
            var sourceListView = sourceListViewGroup.ListView;

            sourceListViewGroup.Items.Remove(sourceListViewItem);
            if (sourceListViewGroup.Items.Count == 0)
            {
                sourceListView.Groups.Remove(sourceListViewGroup);
            }
            sourceListView.Items.Remove(sourceListViewItem);

            // insert in the new list view
            var destinationListView = destinationListViewGroup.ListView;
            sourceListViewItem.Group = destinationListViewGroup;
           
            destinationListViewGroup.Items.Add(sourceListViewItem);
            destinationListView.Items.Add(sourceListViewItem);
        }

        private void InsertListViewItemInNewGroup(ListView destinationListView, ListViewItem sourceListViewItem)
        {
            // remove from previous list view
            var sourceListViewGroup = sourceListViewItem.Group;
            var sourceListView = sourceListViewGroup.ListView;

            sourceListViewGroup.Items.Remove(sourceListViewItem);
            if (sourceListViewGroup.Items.Count == 0)
            {
                sourceListView.Groups.Remove(sourceListViewGroup);
            }
            sourceListView.Items.Remove(sourceListViewItem);

            // create and insert new group
            var sourceServiceItemGroupDTO = sourceListViewGroup.Tag as ServiceItemWithServiceItemGroupDTO;
            var destinationListViewGroup = new ListViewGroup()
            {
                Tag = sourceServiceItemGroupDTO,
                Header = sourceServiceItemGroupDTO.ServiceItemGroupName
            };
            destinationListView.Groups.Add(destinationListViewGroup);

            // insert in the new list view
            sourceListViewItem.Group = destinationListViewGroup;

            destinationListViewGroup.Items.Add(sourceListViewItem);
            destinationListView.Items.Add(sourceListViewItem);
        }

        private void SortListViewGroups(ListView listView)
        {
            var sortedListViewGroups = new ListViewGroup[listView.Groups.Count];
            listView.Groups.CopyTo(sortedListViewGroups, 0);

            Array.Sort(sortedListViewGroups, new ListViewGroupComparer());

            listView.BeginUpdate();
            listView.Groups.Clear();
            listView.Groups.AddRange(sortedListViewGroups);
            listView.EndUpdate();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SaveService();
        }

        private void ExtendedServiceSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            SaveService();
            PrintService();
        }

        private void SaveService()
        {
            if (WorkOrder.Service != null)
            {
                return;
            }

            var selectedServiceTypeId = (long)serviceTypeComboBox.SelectedValue;

            var serviceItems = rightListView.Items.OfType<ListViewItem>()
                .Select(si => si.Tag as ServiceItemWithServiceItemGroupDTO)
                .ToList();

            var appliedServiceItems = serviceItems
                .Select(si =>
                {
                    return new AppliedServiceItem()
                    {
                        ServiceItem = DBContext.ServiceItem.Find(si.Id)
                    };
                })
                .ToList();

            var service = new Service()
            {
                Created = DateTime.Now,
                ServiceType = DBContext.ServiceType.Find(selectedServiceTypeId),
                WorkOrder = WorkOrder,
                AppliedServiceItems = appliedServiceItems
            };

            DBContext.Service.Add(service);
            WorkOrder.Service = service;
            DBContext.SaveChanges();
        }

        private void PrintService()
        {
            var selectedServiceTypeId = (long)serviceTypeComboBox.SelectedValue;

            var serviceItems = rightListView.Items.OfType<ListViewItem>()
                .Select(si => si.Tag as ServiceItemWithServiceItemGroupDTO)
                .ToList();

            var serviceFormReport = new List<CarServiceFormReportDTO>()
            {
                new CarServiceFormReportDTO()
                {
                    WorkOrderNumber = WorkOrder.Number,
                    VehicleIdentificationNumber = WorkOrder.Vehicle.IdentificationNumber,
                    VehicleType = WorkOrder.Vehicle.Type,
                    VehicleTypeCode = WorkOrder.Vehicle.TypeCode,
                    VehicleMKBCode = WorkOrder.Vehicle.MKBCode,
                    VehicleGKBCode = WorkOrder.Vehicle.GKBCode,
                    VehicleRegistrationNumber = WorkOrder.Vehicle.RegistrationNumber,
                    VehicleMileage = WorkOrder.Vehicle.Mileage.ToString(),
                    VehicleRegistrationDate = WorkOrder.Vehicle.RegistrationDate,
                    VehicleModelYear = WorkOrder.Vehicle.ModelYear.ToString(),
                    ServiceType = WorkOrder.Service.ServiceType.Name
        }
            };

            var datasources = new List<ReportDataSource>()
            {
                new ReportDataSource("HeaderDataSet", serviceFormReport),
                new ReportDataSource("BodyDataSet", serviceItems)
            };

            var form = new ReportViewerForm();
            form.SetReport(
                "CarServiceForms.Reports.CarServiceFormReport.rdlc",
                datasources
            );
            form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ali res želite izbrisati izbrani pregled?", "Brisanje pregleda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DBContext.AppliedServiceItem.RemoveRange(WorkOrder.Service.AppliedServiceItems);
                DBContext.Service.Remove(WorkOrder.Service);

                DBContext.SaveChanges();

                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
