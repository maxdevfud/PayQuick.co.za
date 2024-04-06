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

namespace PayQuick
{
    public partial class frmPayrollSummary : Form
    {
        public Employee wEmp;
        public Payroll wPayl;
        public Options wOptn;
        public Employer wEmpr;
        public frmPayrollSummary()
        {
            InitializeComponent();
        }


        private void frmPayrollSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Options' table. You can move, or remove it, as needed.
            this.optionsTableAdapter.Fill(this.dataSet1.Options);
            // TODO: This line of code loads data into the 'dataSet1.Employer' table. You can move, or remove it, as needed.
            this.employerTableAdapter.Fill(this.dataSet1.Employer);
            // TODO: This line of code loads data into the 'dataSet1.Payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.dataSet1.Payroll);
            decimal te = 0;
            decimal toe = 0;
            decimal tgp = 0;
            decimal tpaye = 0;
            decimal tuif = 0;
            decimal tprov = 0;
            decimal toded = 0;
            decimal tded = 0;
            decimal tnp = 0;
            payrollBindingSource.MoveFirst();

            for (int i = 1; i <= payrollBindingSource.Count; i++)

            {
                // drp=payroll drv
                DataRowView drvp = (DataRowView)payrollBindingSource.Current;
                DataRow drp = (DataRow)drvp.Row;
                //n2z(dr["basic_salary_tmp"])
                te = te + n2z(drp["basic_salary"]);
                toe = toe + n2z(drp["other_earnings1_value"]);
                tgp = tgp + n2z(drp["gross_pay"]);

                tpaye = tpaye + n2z(drp["paye"]);
                tuif = tuif + n2z(drp["uif"]);
                tprov = tprov + n2z(drp["providend"]);
                toded = toded + n2z(drp["other_deduction1_value"]);
                tded = tded + n2z(drp["total_deduction"]);

                tnp = tnp + n2z(drp["net_pay"]);



                payrollBindingSource.MoveNext();

            }
            ultraMaskedEdit1.Text = te.ToString();
            ultraMaskedEdit2.Text = toe.ToString();
            ultraMaskedEdit3.Text = tgp.ToString();
            ultraMaskedEdit4.Text = tpaye.ToString();
            ultraMaskedEdit5.Text = tuif.ToString();
            ultraMaskedEdit6.Text = tprov.ToString();
            ultraMaskedEdit7.Text = toded.ToString();
            ultraMaskedEdit8.Text = tded.ToString();
            ultraMaskedEdit9.Text = tnp.ToString();
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal n2z(object fig)
        {
            if (fig == null || fig is DBNull) return (0);


            else
                return (Convert.ToDecimal(fig));

        }

    }
}
