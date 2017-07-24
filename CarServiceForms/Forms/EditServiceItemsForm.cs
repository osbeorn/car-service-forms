using CarServiceForms.Classes;
using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private IList<ServiceItemGroup> ServiceItemGroups { get; set; }
        private BindingList<ServiceItemGroup> ServiceItemGroupsBindingList { get; set; }
        private List<long> DeletedServiceItemGroups { get; set; }

        private IList<ServiceItemWithServiceItemGroupDTO> ServiceItems { get; set; }
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
            serviceItemGroupsDataGridView.AutoGenerateColumns = false;

            SetupServiceItemGroupsDataSource();
                        

            serviceItemsDataGridView.AutoGenerateColumns = false;

            var itemGroupColumn = serviceItemsDataGridView.Columns["itemGroupColumn"] as DataGridViewComboBoxColumn;
            itemGroupColumn.ValueMember = "Id";
            itemGroupColumn.DisplayMember = "Name";
            itemGroupColumn.DataPropertyName = "ServiceItemGroupId";

            SetupServiceItemsDataSource();
        }

        private void SetupServiceItemGroupsDataSource()
        {
            ServiceItemGroups = DBContext.ServiceItemGroup.ToList();
            ServiceItemGroupsBindingList = new BindingList<ServiceItemGroup>(ServiceItemGroups);
            serviceItemGroupsDataGridView.DataSource = ServiceItemGroupsBindingList;
            DeletedServiceItemGroups = new List<long>();
        }

        private void SetupServiceItemsDataSource()
        {
            var itemGroupColumn = serviceItemsDataGridView.Columns["itemGroupColumn"] as DataGridViewComboBoxColumn;
            var serviceItemGroups = DBContext.ServiceItemGroup.ToList();
            itemGroupColumn.DataSource = new BindingList<ServiceItemGroup>(serviceItemGroups);

            ServiceItems = DBContext.ServiceItem
                .Select(si => new ServiceItemWithServiceItemGroupDTO()
                {
                    Id = si.Id,
                    Name = si.Name,
                    Order = si.Order,
                    HasRemarks = si.HasRemarks,
                    ServiceItemGroupId = si.ServiceItemGroup.Id,
                    ServiceItemGroupName = si.ServiceItemGroup.Name,
                    ServiceItemGroupOrder = si.ServiceItemGroup.Order
                })
                .ToList();
            ServiceItemsBindingList = new BindingList<ServiceItemWithServiceItemGroupDTO>(ServiceItems);
            serviceItemsDataGridView.DataSource = ServiceItemsBindingList;
            DeletedServiceItems = new List<long>();
        }

        private void EditServiceItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void RevertServiceItemGroupChangesButton_Click(object sender, EventArgs e)
        {
            SetupServiceItemGroupsDataSource();
            SetupServiceItemsDataSource();
        }

        private void RevertServiceItemChangesButton_Click(object sender, EventArgs e)
        {
            SetupServiceItemsDataSource();
        }

        private void SaveServiceItemGroupChangesButton_Click(object sender, EventArgs e)
        {
            foreach (var serviceItemGroup in ServiceItemGroups)
            {
                if (serviceItemGroup.Id <= 0)
                {
                    serviceItemGroup.Enabled = true;
                    DBContext.ServiceItemGroup.Add(serviceItemGroup);
                }
            }

            foreach (var serviceItemGroupId in DeletedServiceItemGroups)
            {
                var serviceItemGroup = DBContext.ServiceItemGroup.Find(serviceItemGroupId);
                if (serviceItemGroup != null)
                {
                    DBContext.ServiceItemGroup.Remove(serviceItemGroup);
                }
            }
            DeletedServiceItemGroups.Clear();

            DBContext.SaveChanges();

            SetupServiceItemGroupsDataSource();
            SetupServiceItemsDataSource();
        }

        private void SaveServiceItemChangesButton_Click(object sender, EventArgs e)
        {
            foreach (var serviceItemDTO in ServiceItems)
            {
                if (serviceItemDTO.Id <= 0)
                {
                    var serviceItem = new ServiceItem()
                    {
                        Name = serviceItemDTO.Name,
                        Order = serviceItemDTO.Order,
                        Enabled = true,
                        HasRemarks = false,
                        ServiceItemGroup = new ServiceItemGroup()
                        {
                            Id = serviceItemDTO.ServiceItemGroupId
                        }
                    };
                    DBContext.ServiceItem.Add(serviceItem);
                }
                else
                {

                }
            }

            foreach (var serviceItemId in DeletedServiceItems)
            {
                var serviceItem = DBContext.ServiceItem.Find(serviceItemId);
                if (serviceItem != null)
                {
                    DBContext.ServiceItem.Remove(serviceItem);
                }
            }
            DeletedServiceItems.Clear();

            DBContext.SaveChanges();

            SetupServiceItemsDataSource();
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
    }
}
