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

    public partial class frmEmployeeDetail : Form
    {
        private Employee workingEmp;

        public frmEmployeeDetail(Employee _workingEmp)
        {
            InitializeComponent();
            this.workingEmp = _workingEmp;
           
        }

        

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            this.Text = "Employee details for: " + workingEmp.lastname + ", " + workingEmp.firstname;
            ultraTextEditor155.Text = workingEmp.pay_id;
            ultraTextEditor156.Text = workingEmp.lastname;
            ultraTextEditor157.Text = workingEmp.firstname;
            ultraTextEditor158.Text = workingEmp.identity_no;
            ultraTextEditor159.Text = workingEmp.occupation;
            ultraTextEditor160.Text = workingEmp.tax_id;
            ultraDateTimeEditor1.Value = workingEmp.appointed_date;
            ultraComboEditor1.Text = workingEmp.status;
            ultraMaskedEdit1.Value = workingEmp.basic_salary_tmp;
            ultraTextEditor8.Value = workingEmp.other_earnings1_descr_tmp;
            ultraMaskedEdit2.Value = workingEmp.other_earnings1_value_tmp;
            ultraMaskedEdit3.Value = workingEmp.gross_pay_tmp;
            ultraMaskedEdit4.Value = workingEmp.net_pay_tmp;
            ultraMaskedEdit5.Value = workingEmp.paye_tmp;
            ultraMaskedEdit6.Value = workingEmp.uif_tmp;
            ultraMaskedEdit7.Value = workingEmp.providend_tmp;
            ultraTextEditor10.Value = workingEmp.other_deduction1_descr_tmp;
            ultraMaskedEdit8.Value = workingEmp.other_deduction1_value_tmp;
            ultraMaskedEdit9.Value = workingEmp.total_deduction_tmp;
            
        }

        //private void ultraButton1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            //user elected to save so send the values right back

            workingEmp.pay_id = ultraTextEditor155.Text;
            workingEmp.lastname = ultraTextEditor156.Text;
            workingEmp.firstname = ultraTextEditor157.Text;
            workingEmp.identity_no = ultraTextEditor158.Text;
            workingEmp.occupation = ultraTextEditor159.Text;
            workingEmp.tax_id = ultraTextEditor160.Text;
            workingEmp.appointed_date = Convert.ToDateTime(ultraDateTimeEditor1.Value);
            workingEmp.status = ultraComboEditor1.Text;
            workingEmp.basic_salary_tmp = Convert.ToDecimal(ultraMaskedEdit1.Value);
            workingEmp.other_earnings1_descr_tmp = ultraTextEditor8.Text;
            workingEmp.other_earnings1_value_tmp = Convert.ToDecimal(ultraMaskedEdit2.Value);
            workingEmp.gross_pay_tmp = Convert.ToDecimal(ultraMaskedEdit3.Value);
            workingEmp.net_pay_tmp = Convert.ToDecimal(ultraMaskedEdit4.Value);
            workingEmp.paye_tmp = Convert.ToDecimal(ultraMaskedEdit5.Value);
            workingEmp.uif_tmp = Convert.ToDecimal(ultraMaskedEdit6.Value);
            workingEmp.providend_tmp = Convert.ToDecimal(ultraMaskedEdit7.Value);
            workingEmp.other_deduction1_descr_tmp = ultraTextEditor10.Text;
            workingEmp.other_deduction1_value_tmp = Convert.ToDecimal(ultraMaskedEdit8.Value);
            workingEmp.total_deduction_tmp = Convert.ToDecimal(ultraMaskedEdit9.Value);

            //calculate for free!!!

            workingEmp.gross_pay_tmp = (workingEmp.basic_salary_tmp + workingEmp.other_earnings1_value_tmp);
            workingEmp.total_deduction_tmp = (workingEmp.paye_tmp + workingEmp.uif_tmp + workingEmp.providend_tmp + workingEmp.other_deduction1_value_tmp);
            workingEmp.net_pay_tmp = (workingEmp.gross_pay_tmp - workingEmp.total_deduction_tmp);

            ultraMaskedEdit3.Value = workingEmp.gross_pay_tmp;
            ultraMaskedEdit9.Value = workingEmp.total_deduction_tmp;
            ultraMaskedEdit4.Value = workingEmp.net_pay_tmp;




            this.Close();
        }

        private void ultraButton1_Click_1(object sender, EventArgs e)
        {
            // Would love to but cannot really backsave ... since they might yet elect to cancel!

            workingEmp.basic_salary_tmp = Convert.ToDecimal(ultraMaskedEdit1.Value);
            workingEmp.other_earnings1_value_tmp = Convert.ToDecimal(ultraMaskedEdit2.Value);
            workingEmp.paye_tmp = Convert.ToDecimal(ultraMaskedEdit5.Value);
            workingEmp.uif_tmp = Convert.ToDecimal(ultraMaskedEdit6.Value);
            workingEmp.providend_tmp = Convert.ToDecimal(ultraMaskedEdit7.Value);
            workingEmp.other_deduction1_value_tmp = Convert.ToDecimal(ultraMaskedEdit8.Value);

            // Recalc Pay Totals
            // gross pay = basic + other
            // gross deductions = PAYE+UIF+PROV + other
            // net pay = gross pay - gross deductions

            workingEmp.gross_pay_tmp = (workingEmp.basic_salary_tmp + workingEmp.other_earnings1_value_tmp);
            workingEmp.total_deduction_tmp = (workingEmp.paye_tmp + workingEmp.uif_tmp + workingEmp.providend_tmp + workingEmp.other_deduction1_value_tmp);
            workingEmp.net_pay_tmp = (workingEmp.gross_pay_tmp - workingEmp.total_deduction_tmp);

            ultraMaskedEdit3.Value = workingEmp.gross_pay_tmp;
            ultraMaskedEdit9.Value = workingEmp.total_deduction_tmp;
            ultraMaskedEdit4.Value = workingEmp.net_pay_tmp;


        }
    }
}
