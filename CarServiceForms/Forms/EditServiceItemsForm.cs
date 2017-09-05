using CarServiceForms.Classes;
using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class EditServiceItemsForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        private IList<ServiceType> ServiceTypes { get; set; }
        private long CurrentServiceTypeId { get; set; }
        private BindingList<ServiceType> ServiceTypesBindingList { get; set; }
        private List<long> DeletedServiceTypes { get; set; }

        private IList<ServiceItemGroup> ServiceItemGroups { get; set; }
        private long CurrentServiceItemGroupId { get; set; }
        private IList<ServiceItemGroup> CurrentServiceItemGroups { get; set; }
        private BindingList<ServiceItemGroup> ServiceItemGroupsBindingList { get; set; }
        private List<long> DeletedServiceItemGroups { get; set; }

        private IList<ServiceItemWithServiceItemGroupDTO> ServiceItems { get; set; }
        private IList<ServiceItemWithServiceItemGroupDTO> CurrentServiceItems { get; set; }
        private BindingList<ServiceItemWithServiceItemGroupDTO> ServiceItemsBindingList { get; set; }
        private List<long> DeletedServiceItems { get; set; }

        public EditServiceItemsForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            SetupDataGridViews();
        }

        private void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void SetupDataGridViews()
        {
            serviceTypesDataGridView.AutoGenerateColumns = false;
            SetupServiceTypesDataSource();

            serviceItemGroupsDataGridView.AutoGenerateColumns = false;
            SetupServiceItemGroupsDataSource();

            serviceItemsDataGridView.AutoGenerateColumns = false;
            SetupServiceItemsDataSource();
        }

        private void SetupServiceTypesDataSource()
        {
            ServiceTypes = DBContext.ServiceType
                .Where(st => !st.Deleted)
                .ToList();
            ServiceTypesBindingList = new BindingList<ServiceType>(ServiceTypes);
            serviceTypesDataGridView.DataSource = ServiceTypesBindingList;
            DeletedServiceTypes = new List<long>();
        }

        private void SetupServiceItemGroupsDataSource()
        {
            ServiceItemGroups = DBContext.ServiceItemGroup
                .Where(sig => !sig.Deleted)
                .ToList();
            //ServiceItemGroupsBindingList = new BindingList<ServiceItemGroup>(ServiceItemGroups);
            //serviceItemGroupsDataGridView.DataSource = ServiceItemGroupsBindingList;
            DeletedServiceItemGroups = new List<long>();
        }

        private void SetupServiceItemGroupsDataSource(long serviceTypeId)
        {
            CurrentServiceItemGroups = ServiceItemGroups
                .Where(sig => !sig.Deleted && sig.ServiceType.Id == serviceTypeId)
                .ToList();
            ServiceItemGroupsBindingList = new BindingList<ServiceItemGroup>(CurrentServiceItemGroups);
            serviceItemGroupsDataGridView.DataSource = ServiceItemGroupsBindingList;
        }

        private void SetupServiceItemsDataSource()
        {
            ServiceItems = DBContext.ServiceItem
                .Where(si => !si.Deleted)
                .Select(si => new ServiceItemWithServiceItemGroupDTO()
                {
                    Id = si.Id,
                    Name = si.Name,
                    Order = si.Order,
                    HasRemarks = si.HasRemarks,
                    Active = si.Active,
                    Deleted = si.Deleted,
                    ServiceItemGroupId = si.ServiceItemGroup.Id,
                    ServiceItemGroupName = si.ServiceItemGroup.Name,
                    ServiceItemGroupOrder = si.ServiceItemGroup.Order
                })
                .ToList();
            //ServiceItemsBindingList = new BindingList<ServiceItemWithServiceItemGroupDTO>(ServiceItems);
            //serviceItemsDataGridView.DataSource = ServiceItemsBindingList;
            DeletedServiceItems = new List<long>();
        }

        private void SetupServiceItemsDataSource(long serviceItemGroupId)
        {
            CurrentServiceItems = CurrentServiceItemGroups != null && CurrentServiceItemGroups.Count > 0
                ? ServiceItems.Where(si => si.ServiceItemGroupId == serviceItemGroupId).ToList()
                : new List<ServiceItemWithServiceItemGroupDTO>();
            ServiceItemsBindingList = new BindingList<ServiceItemWithServiceItemGroupDTO>(CurrentServiceItems);
            serviceItemsDataGridView.DataSource = ServiceItemsBindingList;
        }

        private void EditServiceItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            serviceTypesDataGridView.CancelEdit();
            serviceItemGroupsDataGridView.CancelEdit();
            serviceItemsDataGridView.CancelEdit();

            UpdateServiceItemGroupsList();
            UpdateServiceItemsList();

            foreach(var serviceType in ServiceTypes)
            {
                if (serviceType.Id <= 0)
                {
                    serviceType.Deleted = false;

                    var serviceTypeId = serviceType.Id;
                    var newServiceType = DBContext.ServiceType.Add(serviceType);
                    UpdateServiceItemGroupsServiceType(serviceTypeId, newServiceType.Id);
                }
                else
                {
                    var originalServiceType = DBContext.ServiceType.Find(serviceType.Id);
                    if (originalServiceType != null)
                    {
                        DBContext.Entry(originalServiceType).CurrentValues.SetValues(serviceType);
                    }
                }
            }

            foreach (var serviceItemGroup in ServiceItemGroups)
            {
                serviceItemGroup.ServiceType = DBContext.ServiceType.Find(serviceItemGroup.ServiceType.Id);

                if (serviceItemGroup.Id <= 0)
                {
                    serviceItemGroup.Deleted = false;

                    var serviceGroupId = serviceItemGroup.Id;
                    var newServiceGroup = DBContext.ServiceItemGroup.Add(serviceItemGroup);
                    UpdateServiceItemsServiceItemGroup(serviceGroupId, newServiceGroup.Id);
                }
                else
                {
                    var originalServiceItemGroup = DBContext.ServiceItemGroup.Find(serviceItemGroup.Id);
                    if (originalServiceItemGroup != null)
                    {
                        DBContext.Entry(originalServiceItemGroup).CurrentValues.SetValues(serviceItemGroup);
                    }
                }
            }

            foreach (var serviceItemDTO in ServiceItems)
            {
                var serviceItem = new ServiceItem()
                {
                    Id = serviceItemDTO.Id,
                    Name = serviceItemDTO.Name,
                    Order = serviceItemDTO.Order,
                    Active = serviceItemDTO.Active,
                    Deleted = serviceItemDTO.Deleted,
                    HasRemarks = false,
                    ServiceItemGroup = DBContext.ServiceItemGroup.Find(serviceItemDTO.ServiceItemGroupId)
                };

                if (serviceItem.Id <= 0)
                {
                    serviceItem.Deleted = false;

                    DBContext.ServiceItem.Add(serviceItem);
                }
                else
                {
                    var originalServiceItem = DBContext.ServiceItem.Find(serviceItem.Id);
                    if (originalServiceItem != null)
                    {
                        DBContext.Entry(originalServiceItem).CurrentValues.SetValues(serviceItem);
                    }
                }
            }

            foreach (var serviceTypeId in DeletedServiceTypes)
            {
                var serviceType = DBContext.ServiceType.Find(serviceTypeId);
                if (serviceType != null)
                {
                    serviceType.Deleted = true;
                }
            }

            foreach (var serviceItemGroupId in DeletedServiceItemGroups)
            {
                var serviceItemGroup = DBContext.ServiceItemGroup.Find(serviceItemGroupId);
                if (serviceItemGroup != null)
                {
                    serviceItemGroup.Deleted = true;
                }
            }

            foreach (var serviceItemId in DeletedServiceItems)
            {
                var serviceItem = DBContext.ServiceItem.Find(serviceItemId);
                if (serviceItem != null)
                {
                    serviceItem.Deleted = true;
                }
            }

            DBContext.SaveChanges();
        }

        private void ServiceItemGroupsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var serviceItemGroup = e.Row.DataBoundItem as ServiceItemGroup;
            if (serviceItemGroup.Id > 0)
            {
                DeletedServiceItemGroups.Add(serviceItemGroup.Id);
            }
        }

        private void ServiceItemsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var serviceItem = e.Row.DataBoundItem as ServiceItem;
            if (serviceItem.Id > 0)
            {
                DeletedServiceItems.Add(serviceItem.Id);
            }
        }

        private void ServiceItemGroupsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["groupIdColumn"].Value = -Convert.ToInt64(new Random().Next());
            e.Row.Cells["groupOrderColumn"].Value = 0;
            e.Row.Cells["groupActiveColumn"].Value = true;
        }

        private void ServiceItemsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["itemIdColumn"].Value = -Convert.ToInt64(new Random().Next());
            e.Row.Cells["itemOrderColumn"].Value = 0;
            e.Row.Cells["itemActiveColumn"].Value = true;
        }

        private void ServiceTypesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (serviceTypesDataGridView.CurrentRow.Index > -1)
            {
                UpdateServiceItemGroupsList();

                var serviceType = serviceTypesDataGridView.CurrentRow.DataBoundItem as ServiceType;

                long serviceTypeId;
                if (serviceType != null)
                {
                    serviceTypeId = serviceType.Id;
                }
                else
                {
                    serviceTypeId = (long)serviceTypesDataGridView.CurrentRow.Cells["serviceTypeIdColumn"].Value;
                }
                CurrentServiceTypeId = serviceTypeId;

                SetupServiceItemGroupsDataSource(serviceTypeId);
            }
        }

        private void ServiceItemGroupsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (serviceItemGroupsDataGridView.CurrentRow.Index > -1)
            {
                UpdateServiceItemsList();

                var serviceItemGroup = serviceItemGroupsDataGridView.CurrentRow.DataBoundItem as ServiceItemGroup;

                long serviceItemGroupId;
                if (serviceItemGroup != null)
                {
                    serviceItemGroupId = serviceItemGroup.Id;
                }
                else
                {
                    serviceItemGroupId = (long)serviceItemGroupsDataGridView.CurrentRow.Cells["groupIdColumn"].Value;
                }
                CurrentServiceItemGroupId = serviceItemGroupId;

                SetupServiceItemsDataSource(serviceItemGroupId);
            }
        }

        private void ServiceTypesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["serviceTypeIdColumn"].Value = -Convert.ToInt64(new Random().Next());
            e.Row.Cells["serviceTypeActiveColumn"].Value = true;
        }

        private void UpdateServiceItemGroupsList()
        {
            if (CurrentServiceItemGroups == null)
            {
                return;
            }

            foreach (var serviceItemGroup in CurrentServiceItemGroups)
            {
                var existingServiceItemGroup = ServiceItemGroups.Where(si => si.Id == serviceItemGroup.Id).FirstOrDefault();
                if (existingServiceItemGroup != null)
                {
                    var index = ServiceItemGroups.IndexOf(existingServiceItemGroup);
                    ServiceItemGroups[index] = existingServiceItemGroup;
                }
                else
                {
                    serviceItemGroup.ServiceType = new ServiceType()
                    {
                        Id = CurrentServiceTypeId
                    };
                    ServiceItemGroups.Add(serviceItemGroup);
                }
            }

            foreach (var serviceItemGroupId in DeletedServiceItemGroups)
            {
                var existingServiceItemGroup = ServiceItemGroups
                    .Where(si => si.Id == serviceItemGroupId)
                    .FirstOrDefault();

                if (existingServiceItemGroup != null)
                {
                    var index = ServiceItemGroups.IndexOf(existingServiceItemGroup);
                    ServiceItemGroups.RemoveAt(index);
                }
            }
        }

        private void UpdateServiceItemsList()
        {
            if (CurrentServiceItems == null)
            {
                return;
            }

            foreach (var serviceItem in CurrentServiceItems)
            {
                var existingServiceItem = ServiceItems
                    .Where(si => si.Id == serviceItem.Id)
                    .FirstOrDefault();

                if (existingServiceItem != null)
                {
                    var index = ServiceItems.IndexOf(existingServiceItem);
                    ServiceItems[index] = existingServiceItem;
                }
                else
                {
                    serviceItem.ServiceItemGroupId = CurrentServiceItemGroupId;
                    ServiceItems.Add(serviceItem);
                }
            }

            foreach (var serviceItemId in DeletedServiceItems)
            {
                var existingServiceItem = ServiceItems
                    .Where(si => si.Id == serviceItemId)
                    .FirstOrDefault();

                if (existingServiceItem != null)
                {
                    var index = ServiceItems.IndexOf(existingServiceItem);
                    ServiceItems.RemoveAt(index);
                }
            }
        }

        private void UpdateServiceItemGroupsServiceType(long oldServiceTypeId, long newServiceTypeId)
        {
            foreach (var serviceItemGroup in ServiceItemGroups)
            {
                if (serviceItemGroup.ServiceType.Id == oldServiceTypeId)
                {
                    serviceItemGroup.ServiceType = new ServiceType()
                    {
                        Id = newServiceTypeId
                    };
                }
            }
        }

        private void UpdateServiceItemsServiceItemGroup(long oldServiceGroupId, long newServiceGroupId)
        {
            foreach (var serviceItem in ServiceItems)
            {
                if (serviceItem.ServiceItemGroupId == oldServiceGroupId)
                {
                    serviceItem.ServiceItemGroupId = newServiceGroupId;
                }
            }
        }

        private void ServiceTypesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
            }
        }

        private void ServiceItemGroupsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
            }
        }

        private void ServiceItemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            serviceTypesDataGridView.CancelEdit();
            serviceItemGroupsDataGridView.CancelEdit();
            serviceItemsDataGridView.CancelEdit();
        }

        private void EditServiceItemsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
