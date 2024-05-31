using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy_Hub.UI
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        public void LoadReport(string reportFileName)
        {
            ReportDocument reportDocument = new ReportDocument();

            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            projectDirectory = Directory.GetParent(Directory.GetParent(projectDirectory).FullName).FullName;
            projectDirectory = projectDirectory.Replace("\\bin", "");
            projectDirectory = Path.Combine(projectDirectory, "CrystalReports");
            string fpath = Path.Combine(projectDirectory, reportFileName);

            try
            {
                reportDocument.Load(fpath);
                crystalReportViewer1.ReportSource = reportDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
