using Microsoft.Reporting.WinForms;
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
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm()
        {
            InitializeComponent();
        }

        public void SetReport(string reportPath, List<ReportDataSource> dataSources)
        {
            reportViewer.Reset();
            reportViewer.LocalReport.DataSources.Clear();

            reportViewer.LocalReport.ReportEmbeddedResource = reportPath;
            reportViewer.LocalReport.DataSources.Clear();
            foreach (var dataSource in dataSources)
            {
                reportViewer.LocalReport.DataSources.Add(dataSource);
            }

            Show();
            Focus();
            reportViewer.RefreshReport();
        }
    }
}
