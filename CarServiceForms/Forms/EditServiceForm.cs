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
    public partial class EditServiceForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        public EditServiceForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            serviceItemGroupsDataGridView.AutoGenerateColumns = false;
            serviceItemsDataGridView.AutoGenerateColumns = false;

            serviceItemGroupsDataGridView.DataSource = new BindingList<ServiceItemGroup>(DBContext.ServiceItemGroup.ToList());
            serviceItemsDataGridView.DataSource = new BindingList<ServiceItem>(DBContext.ServiceItem.ToList());
        }
    }
}
