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
    public partial class WorkOrderListForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        public WorkOrderListForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            workOrdersDataGridView.AutoGenerateColumns = false;

            LoadWorkOrders();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (var form = new WorkOrderForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadWorkOrders();
                }
            }
        }

        private void LoadWorkOrders()
        {
            var workOrders = DBContext.WorkOrder.ToList();
            workOrdersDataGridView.DataSource = workOrders;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var serviceItems = DBContext.ServiceItem;

        }
    }
}
