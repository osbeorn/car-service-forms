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
    public partial class EditServiceTypesForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        private IList<ServiceItemWithServiceTypeDTO> ServiceItemServiceTypes { get; set; }
        private BindingList<ServiceItemWithServiceTypeDTO> ServiceItemServiceTypesBindingList { get; set; }
        private List<long> DeletedServiceItemServiceTypes { get; set; }

        public EditServiceTypesForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            SetupDataGridView();
        }

        private void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void SetupDataGridView()
        {
            serviceItemServiceTypesDataGridView.AutoGenerateColumns = false;

            var serviceTypeColumn = serviceItemServiceTypesDataGridView.Columns["serviceTypeColumn"] as DataGridViewComboBoxColumn;
            serviceTypeColumn.ValueMember = "Id";
            serviceTypeColumn.DisplayMember = "Name";
            serviceTypeColumn.DataPropertyName = "ServiceType";

            SetupServiceItemServiceTypesDataSource();
        }

        private void SetupServiceItemServiceTypesDataSource()
        {
            var serviceTypeColumn = serviceItemServiceTypesDataGridView.Columns["serviceTypeColumn"] as DataGridViewComboBoxColumn;
            var serviceTypes = new List<dynamic>()
            {
                new
                {
                    Id = ServiceType.Inspection,
                    Name = "servisni pregled (časovno ali kilometrsko pogojeni)"
                },
                new
                {
                    Id = ServiceType.Interval,
                    Name = "intervalni servis (fiksno)"
                },
                new
                {
                    Id = ServiceType.OilChange,
                    Name = "servis z menjavo olja"
                },
            };
            serviceTypeColumn.DataSource = new BindingList<dynamic>(serviceTypes);

            ServiceItemServiceTypes = DBContext.ServiceItemServiceType
                .OrderBy(sist => sist.ServiceType)
                .ThenBy(sist => sist.ServiceItem.ServiceItemGroup.Order)
                .ThenBy(sist => sist.ServiceItem.Order)
                .Select(si => new ServiceItemWithServiceTypeDTO()
                {
                    Id = si.Id,
                    ServiceItemId = si.ServiceItem.Id,
                    ServiceItemName = si.ServiceItem.Name,
                    ServiceType = si.ServiceType
                })
                .ToList();
            ServiceItemServiceTypesBindingList = new BindingList<ServiceItemWithServiceTypeDTO>(ServiceItemServiceTypes);

            serviceItemServiceTypesDataGridView.DataSource = ServiceItemServiceTypesBindingList;

            DeletedServiceItemServiceTypes = new List<long>();
        }

        private void EditServiceTypesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            foreach (var serviceItemServiceTypeDTO in ServiceItemServiceTypes)
            {
                var serviceItemServiceType = new ServiceItemServiceType()
                {
                    Id = serviceItemServiceTypeDTO.Id,
                    ServiceItem = new ServiceItem()
                    {
                        Id = serviceItemServiceTypeDTO.Id
                    },
                    ServiceType = serviceItemServiceTypeDTO.ServiceType
                };

                var originalServiceItemServiceType = DBContext.ServiceItemServiceType.Find(serviceItemServiceType.Id);
                if (originalServiceItemServiceType != null)
                {
                    DBContext.Entry(originalServiceItemServiceType).CurrentValues.SetValues(serviceItemServiceType);
                }
            }

            foreach (var serviceItemServiceTypeId in DeletedServiceItemServiceTypes)
            {
                var serviceItemServiceType = DBContext.ServiceItemServiceType.Find(serviceItemServiceTypeId);
                if (serviceItemServiceType != null)
                {
                    DBContext.ServiceItemServiceType.Remove(serviceItemServiceType);
                }
            }
            DeletedServiceItemServiceTypes.Clear();

            DBContext.SaveChanges();

            SetupServiceItemServiceTypesDataSource();
        }

        private void ServiceItemsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var serviceItemServiceType = e.Row.DataBoundItem as ServiceItemWithServiceTypeDTO;
            if (serviceItemServiceType.Id > 0)
            {
                DeletedServiceItemServiceTypes.Add(serviceItemServiceType.Id);
            }
        }
    }
}
