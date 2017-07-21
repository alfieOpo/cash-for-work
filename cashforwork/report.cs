using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace cashforwork
{
    public partial class report : UserControl
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Visible = false;
            date_from.Value = DateTime.Now;
            date_to.Value = DateTime.Now;
            rdn_none.Checked = true;
            cbo_barangay.SelectedIndex = 0;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            load_report();
            this.reportViewer1.RefreshReport();
            
        }
        private void load_report()
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();
            ReportParameter p1 = new ReportParameter("date_from", date_from.Value.ToShortDateString());
            ReportParameter p2 = new ReportParameter("date_to", date_to.Value.ToShortDateString());
            ReportParameter p3 = new ReportParameter("batch", num_batch.Value.ToString());
            this.reportViewer1.LocalReport.SetParameters(p1);
            this.reportViewer1.LocalReport.SetParameters(p2);
            this.reportViewer1.LocalReport.SetParameters(p3);
            string sql = "";

            string param = "";
            //string filtervalue = "This report is filtered by Date of registration from " + date_from.Value.ToShortDateString() + " to " + date_to.Value.ToShortDateString();

            string filtervalue = "This report is filtered by Date of registration";
            if (num_batch.Value != 0)
            {
                param += " and batch=" + num_batch.Value;
                filtervalue += " , Batch " + num_batch.Value;
            }
            if (!cbo_barangay.Text.ToLower().Equals("all")) {
                param += " and barangay='" + cbo_barangay.Text+"'";
                filtervalue += " , Barangay " + cbo_barangay.Text;
            }
            if(!rdn_none.Checked){

                string gender=rdn_female.Checked?"'Female'":"'Male'";
                    param+= " and gender ="+gender;
                    filtervalue += ", Gender " + gender.Replace("'","");
            }
            ReportParameter p4 = new ReportParameter("note", filtervalue);
            this.reportViewer1.LocalReport.SetParameters(p4);
            sql = @"select ROW_NUMBER() OVER (Order by [barangay]) AS id
            ,[f_name]
            ,[m_name]
            ,[l_name]
            ,[barangay]
            ,[contact_number]
            ,[birthday]
            ,[nhts]
            ,[non_nhts]
            ,fourps
            ,[gender]
            ,[date_registeer]
            ,[image]
            ,[batch]
            from vw_cfw_report where date_registeer between cast('" + date_from.Value.ToString("yyyy-MM-dd") + "' as date) and cast('" + date_to.Value.ToString("yyyy-MM-dd") + "' as date) " + param + " ORDER BY [barangay]";
         
            DataTable dt = new DataTable();
            
            if (Program.da.query(sql))
            {
                dt = Program.da.getTable();
                this.reportViewer1.Visible = true;
            }
            else
            {
                this.reportViewer1.Visible = false;
                Mainform form = (Mainform)this.ParentForm;
                
                CustomMessageForm.CustomMessageBox.Show("Warning", "No record/s found", form);               

            }


            ReportDataSource rprtDTSource = new ReportDataSource();
            rprtDTSource.Name = "DataSet1";
            rprtDTSource.Value = dt;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
