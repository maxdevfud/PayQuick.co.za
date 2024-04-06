using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainModel;
using FastReport;

namespace PayQuick
{


    public partial class frmPaySchedule : Form
    {
        public Employee wEmp;
        public Payroll wPayl;
        public Options wOptn;
        public Employer wEmpr;
        public frmPaySchedule()
        {
            InitializeComponent();
        }

        private void frmPaySchedule_Load(object sender, EventArgs e)
        {
            this.employerTableAdapter.Fill(this.DataSet1.Employer);
            this.optionsTableAdapter.Fill(this.DataSet1.Options);
            this.PayrollTableAdapter.Fill(this.DataSet1.Payroll);
            PayrollBindingSource.Sort = "lastname";

            //get blank options and employer details, in case system not yet initialised
            //then fill from 1st records of bindingsource(drv.dr) if reccount > 0
            Options workingOpt = new Options();
            workingOpt = blankOptions(workingOpt);
            if (optionsBindingSource.Count > 0)
            {
                RowToWorkingOptions(workingOpt);
            }

            wOptn = workingOpt;



            string RepHeading = "Salary Schedule";

            if (wOptn.pay_cycle == "Weekly")
            {
                RepHeading = "Wage Schedule";
            }





            Employer workingEmplr = new Employer();
            workingEmplr = blankEmployer(workingEmplr);

            if (employerBindingSource.Count > 0)
            {

                RowToWorkingEmployer(workingEmplr);
            }

            wEmpr = workingEmplr;




            //ReportParameter rp1 = new ReportParameter("@EmployerName", workingEmplr.name.ToString());
            //ReportParameter rp2 = new ReportParameter("@PayDate", workingOpt.pay_date.ToString());
            
            //ReportParameter[] Parameters = new ReportParameter[2];
            
            string zeta = workingOpt.pay_date.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show("Zeta: " + zeta);
            //zeta = "toffie";


            //Parameters[0] = new ReportParameter("EmployerName", workingEmplr.name.ToString());
            //Parameters[1] = new ReportParameter("PayDate", zeta);

            //reportViewer1.LocalReport.SetParameters(Parameters);
            //PayrollBindingSource.MoveFirst();
            //this.reportViewer1.RefreshReport();

            // create report instance
            FastReport.Report report = new FastReport.Report();

           

            report.Load("SalarySchedule.frx");
            report.RegisterData(DataSet1);

            string pqprocessor = Properties.Settings.Default.pqprocessor;

            string pqslogan = Properties.Settings.Default.pqslogan;

            string pqrepheading = RepHeading;

            report.SetParameterValue("EmployerName", workingEmplr.name.ToString());
            report.SetParameterValue("PayDate", zeta);
            report.SetParameterValue("pqprocessor", pqprocessor);
            report.SetParameterValue("pqslogan", pqslogan);
            report.SetParameterValue("pqrepheading", pqrepheading);


            report.GetDataSource("Payroll").Enabled = true;

            if (System.IO.File.Exists("debug.raw"))
            {
                report.Design();
            }
            else
            {
                report.Show();
            }

            report.Dispose();
            this.Close();


        }

        private decimal n2z(object fig)
        {
            if (fig == null || fig is DBNull) return (0);


            else
                return (Convert.ToDecimal(fig));

        }
        private Options blankOptions(Options wOptn)
        {
            wOptn.ID = 0;
            wOptn.current_month = "";
            wOptn.pay_date = DateTime.Today;
            return wOptn;
        }

        private Employer blankEmployer(Employer wEmpr)
        {
            wEmpr.ID = 0;
            wEmpr.paymonth = "";
            wEmpr.paydate = DateTime.Today;
            return wEmpr;
        }

        private void RowToWorkingOptions(Options workingOpt)
        {
            DataRowView drvt = (DataRowView)optionsBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            workingOpt.ID = Convert.ToInt32(dr["ID"]);
            workingOpt.current_month = dr["current_month"].ToString();
            workingOpt.pay_date = Convert.ToDateTime(dr["pay_date"]);
            workingOpt.pay_cycle = dr["pay_cycle"].ToString();
        }
        private void RowToWorkingEmployer(Employer workingEmpr)
        {
            DataRowView drvt = (DataRowView)employerBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            workingEmpr.ID = Convert.ToInt32(dr["ID"]);
            workingEmpr.name = dr["name"].ToString();
            workingEmpr.addr1 = dr["addr1"].ToString();
            workingEmpr.addr2 = dr["addr2"].ToString();
            workingEmpr.addr3 = dr["addr3"].ToString();
            workingEmpr.addr4 = dr["addr4"].ToString();
            workingEmpr.paye_id = dr["paye_id"].ToString();
            workingEmpr.uif_id = dr["uif_id"].ToString();
            workingEmpr.sdl_id = dr["sdl_id"].ToString();
            workingEmpr.currentstart = Convert.ToDateTime(dr["currentstart"]);
            workingEmpr.currentend = Convert.ToDateTime(dr["currentend"]);
            workingEmpr.database_path = dr["database_path"].ToString();
            workingEmpr.tel = dr["tel"].ToString();
            workingEmpr.email = dr["email"].ToString();
            workingEmpr.contact = dr["contact"].ToString();
            workingEmpr.paydate = Convert.ToDateTime(dr["paydate"]);
            workingEmpr.paymonth = dr["paymonth"].ToString();
        }

    }
}
