using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrosstabControlCustomizationExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            listBoxControl1.DataSource = ReportDescriptionData.GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listBoxControl1.Items.Count > 0)
                listBoxControl1.SelectedIndex = 0;
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            // Open a selected report in the report designer.
            XRDesignForm form = new XRDesignForm();
            string name = GetSelectedName();
            if (!string.IsNullOrEmpty(name))
            {
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(name));
                form.OpenReport(report);
            }
            form.ShowDialog(this);

            object selectedItem = listBoxControl1.SelectedItem;
            if (selectedItem != null && listBoxControl1.Items.Contains(selectedItem))
                listBoxControl1.SelectedItem = selectedItem;
        }

        private string GetSelectedName()
        {
            return ((DataItem)listBoxControl1.SelectedItem).ReportName;
        }
    }
}
