using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mainModel;
using System.Drawing.Printing;
using QALock;

namespace PayQuick
{
    public partial class Form1 : Form
    {
        public Employee wEmp;
        public Payroll wPayl;
        public Options wOptn;
        public Employer wEmpr;
        public Form1()
        {
            InitializeComponent();
        }
        #region Tabwizardcontroller
        private void tabWizard_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            int totaltabs = tabWizard.Tabs.Count - 1;
            int tabindex = tabWizard.ActiveTab.Index;
            int position = totaltabs - tabindex;
            if (btnNext.Text == "Finish" && position == totaltabs) this.Close();
            if (position == 0)
            {
                btnBack.Enabled = true;
                //btnNext.Enabled = false;
                //btnNext.Text = "";
            }
            else if (position == totaltabs)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                //btnNext.Text = "";
            }
            else
            {
                //btnNext.Text = "";
                btnBack.Enabled = true;
                btnNext.Enabled = true;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            tabWizard.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.NavigateNextTab);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabWizard.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.NavigatePreviousTab);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            string serialno;
            string appstatus;
            appstatus = "hello";
            
            tLock1.ActiveFileName = "YouractivefileName";
            tLock1.LockFilePath = QALock.TLockFilePath.CurrentDir;
            tLock1.SerialFileName = "YourserialfileName";
            tLock1.ApplicationIdentity = "985321";//must be 6 digit number
            try
            {
                //tLock1.GetSerialNumber();
                serialno = tLock1.GetSerialNumber();
                //MessageBox.Show("Serial No. " + serialno);
                bool reg = tLock1.CheckRegistration();
                switch (reg)
                {
                    case true:
                        appstatus = "REGISTERED";
                        break;
                    case false:
                        appstatus = "NOT REGISTERED";
                        break;
                }

                if (System.IO.File.Exists("debug.raw"))
                {
                    MessageBox.Show("PayQuick Status: " + appstatus + "-- - Serial No. " + serialno);
                }


            }
            catch
            {
                tLock1.Reset();
            }

            //developer mode only: to play around with registration//
            if (System.IO.File.Exists("debug.raw"))
            {
                appstatus = "NOT REGISTERED";
            }



            if (appstatus == "NOT REGISTERED")
            {
                //display registration screen
                // validate
                // if NOT validated - abort
                frmRegisterPayQuick fr = new frmRegisterPayQuick();
                fr.ShowDialog();
            }
            //MessageBox.Show("PayQuick Registration Status: " + appstatus + " " + "Serial No. " + serialno);


            //still have payroll table to handle as well

            this.payrollTableAdapter.Fill(this.dataSet1.Payroll);
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            this.OptionsTableAdapter.Fill(this.dataSet1.Options);
            this.employerTableAdapter.Fill(this.dataSet1.Employer);

            //get blank options and employer details, in case system not yet initialised
            //then fill from 1st records of bindingsource(drv.dr) if reccount > 0
            Options workingOpt = new Options();
            workingOpt = blankOptions(workingOpt);
            if (OptionsbindingSource.Count > 0)
            {
                RowToWorkingOptions(workingOpt);
            }



            // Get PayQuick Options
            Options workingOptn = new Options();
            workingOptn = blankOptions(workingOptn);

            if (OptionsbindingSource.Count > 0)
            {
                RowToWorkingOptions(workingOptn);
            }



            wOptn = workingOptn;
            //


            // Get employer defaults
            Employer workingEmplr = new Employer();
            workingEmplr = blankEmployer(workingEmplr);

            if (employerbindingSource.Count > 0)
            {

                RowToWorkingEmployer(workingEmplr);
            }

            wEmpr = workingEmplr;


            //

            if (wOptn.pay_cycle == "Weekly")
            {
                this.Text = "PayQuick.co.za for : " + wEmpr.name + " - Weekly";
                ultraGroupBox2.Text = "Step 2 of 4 - Process Wages";
                ultraComboEditor2.Enabled = false;
                ultraLabel21.Text = "Weekly";
            }
            else
            {
                this.Text = "PayQuick.co.za for : " + wEmpr.name + " - Month of: " + wEmpr.paymonth;
            }

            //MessageBox.Show("Month: " + workingOpt.current_month);
            ultraComboEditor2.Text = workingOpt.current_month;
            ultraDateTimeEditor2.Value = workingOpt.pay_date;

            this.ultraPrintPreviewDialog1.Document = this.ultraPrintDocument1;
            ultraLabel26.Text = workingEmplr.name;
            ultraLabel27.Text = workingEmplr.addr1 + " | " + workingEmplr.addr2 + " | " + workingEmplr.addr3 + " | " + workingEmplr.addr4;
            string dateP = workingOpt.pay_date.ToString();
            string left = dateP.Substring(0, 10);
            ultraLabel28.Text = "Payslip date: " + left;

        }

        private void ultraButton4_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            ultraGrid1.Refresh();
        }


        private void ultraButton5_Click_1(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(dataSet1.Employee);
            MessageBox.Show("Employee Changes Saved");
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
            ultraComboEditor1.Text = "Active";
            ultraTextEditor1.Focus();
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            //MessageBox.Show("clicked: "+ e.Tool.CaptionResolved.ToString());
            if (e.Tool.CustomizerCaptionResolved == "Employer Details")
            {
                frmEmployer frm = new frmEmployer();
                frm.ShowDialog();
            }
            if (e.Tool.CustomizerCaptionResolved == "PayQuick Options")
            {
                frmOptions frm = new frmOptions();
                frm.ShowDialog();
            }
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Employee?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                employeeBindingSource.RemoveCurrent();
                if (ultraGrid1.ActiveRow == null)
                {
                    employeeBindingSource.MoveNext();
                    employeeBindingSource.MovePrevious();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //revert with no action taken
            }
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            Employee workingEmp = new Employee();
            workingEmp = blankEmp(workingEmp);

            RowToWorkingEmployee(workingEmp);
            //MessageBox.Show(workingEmp.other_deduction1_descr_tmp);
            //instantiate the employee detail form
            frmEmployeeDetail frm = new frmEmployeeDetail(workingEmp);

            //Display employee Detail Form
            frm.ShowDialog();

            //MessageBox.Show("Return dialog " + frm.DialogResult.ToString());
            if (frm.DialogResult == DialogResult.OK)
            {
                WorkingEmployeeToRow(workingEmp);
                frm.Dispose();
            }
            else
            {
                // do nothing

                frm.Dispose();
            }
        }

        private Employee blankEmp(Employee wEmp)
        {
            wEmp.ID = 0;
            wEmp.lastname = "";
            wEmp.firstname = "";
            wEmp.identity_no = "";
            wEmp.pay_id = "";
            wEmp.occupation = "";
            wEmp.appointed_date = DateTime.Today;
            wEmp.tax_id = "";
            wEmp.status = "Active";
            wEmp.basic_salary_tmp = 0;
            wEmp.other_earnings1_descr_tmp = "";
            wEmp.other_earnings1_value_tmp = 0;
            wEmp.gross_pay_tmp = 0;
            wEmp.net_pay_tmp = 0;
            wEmp.paye_tmp = 0;
            wEmp.uif_tmp = 0;
            wEmp.providend_tmp = 0;
            wEmp.other_deduction1_descr_tmp = "";
            wEmp.other_deduction1_value_tmp = 0;
            wEmp.total_deduction_tmp = 0;
            return wEmp;
        }


        private void RowToWorkingEmployee(Employee workingEmp)
        {
            DataRowView drvt = (DataRowView)employeeBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            workingEmp.ID = Convert.ToInt32(dr["ID"]);
            workingEmp.lastname = dr["lastname"].ToString();
            workingEmp.firstname = dr["firstname"].ToString();
            workingEmp.identity_no = dr["identity_no"].ToString();
            workingEmp.pay_id = dr["pay_id"].ToString();
            workingEmp.occupation = dr["occupation"].ToString();
            workingEmp.appointed_date = n2d(dr["appointed_date"]);
            workingEmp.pay_id = dr["pay_id"].ToString();
            workingEmp.tax_id = dr["tax_id"].ToString();
            workingEmp.status = dr["status"].ToString();
            workingEmp.basic_salary_tmp = n2z(dr["basic_salary_tmp"]);
            workingEmp.other_earnings1_descr_tmp = dr["other_earnings1_descr_tmp"].ToString();
            workingEmp.other_earnings1_value_tmp = n2z(dr["other_earnings1_value_tmp"]);
            workingEmp.gross_pay_tmp = n2z(dr["gross_pay_tmp"]);
            workingEmp.net_pay_tmp = n2z(dr["net_pay_tmp"]);
            workingEmp.paye_tmp = n2z(dr["paye_tmp"]);
            workingEmp.uif_tmp = n2z(dr["uif_tmp"]);
            workingEmp.providend_tmp = n2z(dr["providend_tmp"]);
            workingEmp.other_deduction1_descr_tmp = dr["other_deduction1_descr_tmp"].ToString();
            workingEmp.other_deduction1_value_tmp = n2z(dr["other_deduction1_value_tmp"]);
            workingEmp.total_deduction_tmp = n2z(dr["total_deduction_tmp"]);
        }

        private void WorkingEmployeeToRow(Employee workingEmp)
        {
            DataRowView drvt = (DataRowView)employeeBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            dr["ID"] = workingEmp.ID;
            dr["lastname"] = workingEmp.lastname;
            dr["firstname"] = workingEmp.firstname;
            dr["identity_no"] = workingEmp.identity_no;
            dr["pay_id"] = workingEmp.pay_id;
            dr["occupation"] = workingEmp.occupation;
            dr["appointed_date"] = workingEmp.appointed_date;
            dr["pay_id"] = workingEmp.pay_id;
            dr["tax_id"] = workingEmp.tax_id;
            dr["status"] = workingEmp.status;
            dr["basic_salary_tmp"] = workingEmp.basic_salary_tmp;
            dr["other_earnings1_descr_tmp"] = workingEmp.other_earnings1_descr_tmp;
            dr["other_earnings1_value_tmp"] = workingEmp.other_earnings1_value_tmp;
            dr["gross_pay_tmp"] = workingEmp.gross_pay_tmp;
            dr["net_pay_tmp"] = workingEmp.net_pay_tmp;
            dr["paye_tmp"] = workingEmp.paye_tmp;
            dr["uif_tmp"] = workingEmp.uif_tmp;
            dr["providend_tmp"] = workingEmp.providend_tmp;
            dr["other_deduction1_descr_tmp"] = workingEmp.other_deduction1_descr_tmp;
            dr["other_deduction1_value_tmp"] = workingEmp.other_deduction1_value_tmp;
            dr["total_deduction_tmp"] = workingEmp.total_deduction_tmp;
        }

        private decimal n2z(object fig)
        {
            if (fig == null || fig is DBNull) return (0);

            
            else
                return (Convert.ToDecimal(fig));

        }

        private DateTime n2d(object fig)
        {
            if (fig == null || fig is DBNull) return (DateTime.Now);


            else
                return (Convert.ToDateTime(fig));

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
            DataRowView drvt = (DataRowView)OptionsbindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            workingOpt.ID = Convert.ToInt32(dr["ID"]);
            workingOpt.current_month = dr["current_month"].ToString();
            workingOpt.pay_date = n2d(dr["pay_date"]);
            workingOpt.pay_cycle = dr["pay_cycle"].ToString();
        }
        private void RowToWorkingEmployer(Employer workingEmpr)
        {
            DataRowView drvt = (DataRowView)employerbindingSource.Current;
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
            workingEmpr.currentstart = n2d(dr["currentstart"]);
            workingEmpr.currentend = n2d(dr["currentend"]);
            workingEmpr.database_path = dr["database_path"].ToString();
            workingEmpr.tel = dr["tel"].ToString();
            workingEmpr.email = dr["email"].ToString();
            workingEmpr.contact = dr["contact"].ToString();
            workingEmpr.paydate = n2d(dr["paydate"]);
            workingEmpr.paymonth = dr["paymonth"].ToString();
        }

        private void ultraButton13_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Start Fresh Payroll for month of "+ ultraComboEditor2.Text + "?", "", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                // Loop through all employees, derive data, add to payroll table
                // pay_date and paymonth -> update 1.options table, 2.working Options and 3. display vars:ultracomboeditor2, ultradatetimeeditor2
                #region Establish Fresh Payroll Table
                if (payrollBindingSource.Count > 0)
                {
                    do
                    {
                        payrollBindingSource.RemoveCurrent();
                    }
                    while (payrollBindingSource.Count > 0);
                }
                employeeBindingSource.MoveFirst();
                for (int i = 0; i < employeeBindingSource.Count; i++)
                {
                    // get requisite fields from constants and employee register
                    DataRowView drv = (DataRowView)employeeBindingSource.Current;
                    DataRow dr = (DataRow)drv.Row;


                    //remember: below processing only for ACTIVE employees





                    // note: dr=employee drv, drp=payroll drv

                    if (dr["status"].ToString() == "Active")
                    {
                        payrollBindingSource.AddNew();
                        DataRowView drvp = (DataRowView)payrollBindingSource.Current;
                        DataRow drp = (DataRow)drvp.Row;
                        drp["lastname"] = dr["lastname"];
                        drp["firstname"] = dr["firstname"];
                        drp["identity_no"] = dr["identity_no"];
                        drp["pay_id"] = dr["pay_id"];
                        drp["occupation"] = dr["occupation"];
                        drp["appointed_date"] = dr["appointed_date"];
                        drp["tax_id"] = dr["tax_id"];
                        drp["status"] = dr["status"];
                        drp["basic_salary"] = dr["basic_salary_tmp"];
                        drp["other_earnings1_value"] = dr["other_earnings1_value_tmp"];
                        drp["other_earnings1_descr"] = dr["other_earnings1_descr_tmp"];
                        drp["paye"] = dr["paye_tmp"];
                        drp["uif"] = dr["uif_tmp"];
                        drp["providend"] = dr["providend_tmp"];
                        drp["other_deduction1_value"] = dr["other_deduction1_value_tmp"];
                        drp["other_deduction1_descr"] = dr["other_deduction1_descr_tmp"];
                        drp["gross_pay"] = dr["gross_pay_tmp"];
                        drp["total_deduction"] = dr["total_deduction_tmp"];
                        drp["net_pay"] = dr["net_pay_tmp"];
                        drp["pay_date"] = ultraDateTimeEditor2.Value;
                        drp["empID"] = dr["ID"];
                    }
                    // next employee record
                    employeeBindingSource.MoveNext();
                }
                payrollTableAdapter.Update(dataSet1);
                payrollBindingSource.MoveFirst();
                #endregion

                #region Establish  month-end constants
                // easy ones first

                wOptn.current_month = ultraComboEditor2.Text;
                wOptn.pay_date = ultraDateTimeEditor2.DateTime;
                string dateP = wOptn.pay_date.ToString();
                string left = dateP.Substring(0, 10);
                ultraLabel28.Text = "Payslip date: " + left;
                DataRowView drvt = (DataRowView)OptionsbindingSource.Current;
                DataRow odr = (DataRow)drvt.Row;
                odr["current_month"] = wOptn.current_month;
                odr["pay_date"] = wOptn.pay_date;
                OptionsTableAdapter.Update(dataSet1);


                #endregion
                MessageBox.Show("Just Baked fresh Payroll for: " + ultraComboEditor2.Text);
            }
            else if (dialogResult == DialogResult.No)
            {
                //revert with no action taken
            }
        }

        private void ultraButton11_Click(object sender, EventArgs e)
        {
            payrollBindingSource.MoveNext();
        }

        private void ultraButton12_Click(object sender, EventArgs e)
        {
            payrollBindingSource.MovePrevious();
        }

        private void ultraButton23_Click(object sender, EventArgs e)
        {
            //recalculate nett pay on payroll screen
            //
            //Mrow2workingemployee - plug the values into workingEmp class object from mix of payroll screen and payroll row
            //perform calculations
            //workingemployee2prow - reverse values from workingEmp to payroll row

            Employee workingEmp = new Employee();
            workingEmp = blankEmp(workingEmp);

            MrowToWorkingEmployee(workingEmp);

            //override based on screen entries - this is mix

            //n2z(dr["basic_salary_tmp"]);
            workingEmp.basic_salary_tmp = n2z(ultraMaskedEdit1.Value);
            workingEmp.other_earnings1_value_tmp = n2z(ultraMaskedEdit2.Value);
            workingEmp.paye_tmp = n2z(ultraMaskedEdit5.Value);
            workingEmp.uif_tmp = n2z(ultraMaskedEdit6.Value);
            workingEmp.providend_tmp = n2z(ultraMaskedEdit7.Value);
            workingEmp.other_deduction1_value_tmp = n2z(ultraMaskedEdit8.Value);

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


            WorkingEmployeeToMrow(workingEmp);
        }

        private void MrowToWorkingEmployee(Employee workingEmp)
        {
            DataRowView drvt = (DataRowView)payrollBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            workingEmp.ID = Convert.ToInt32(dr["ID"]);
            workingEmp.lastname = dr["lastname"].ToString();
            workingEmp.firstname = dr["firstname"].ToString();
            workingEmp.identity_no = dr["identity_no"].ToString();
            workingEmp.pay_id = dr["pay_id"].ToString();
            workingEmp.occupation = dr["occupation"].ToString();
            workingEmp.appointed_date = n2d(dr["appointed_date"]);
            workingEmp.pay_id = dr["pay_id"].ToString();
            workingEmp.tax_id = dr["tax_id"].ToString();
            workingEmp.status = dr["status"].ToString();
            workingEmp.basic_salary_tmp = n2z(dr["basic_salary"]);
            workingEmp.other_earnings1_descr_tmp = dr["other_earnings1_descr"].ToString();
            workingEmp.other_earnings1_value_tmp = n2z(dr["other_earnings1_value"]);
            workingEmp.gross_pay_tmp = n2z(dr["gross_pay"]);
            workingEmp.net_pay_tmp = n2z(dr["net_pay"]);
            workingEmp.paye_tmp = n2z(dr["paye"]);
            workingEmp.uif_tmp = n2z(dr["uif"]);
            workingEmp.providend_tmp = n2z(dr["providend"]);
            workingEmp.other_deduction1_descr_tmp = dr["other_deduction1_descr"].ToString();
            workingEmp.other_deduction1_value_tmp = n2z(dr["other_deduction1_value"]);
            workingEmp.total_deduction_tmp = n2z(dr["total_deduction"]);
        }

        private void WorkingEmployeeToMrow(Employee workingEmp)
        {
            DataRowView drvt = (DataRowView)payrollBindingSource.Current;
            DataRow dr = (DataRow)drvt.Row;
            dr["ID"] = workingEmp.ID;
            dr["lastname"] = workingEmp.lastname;
            dr["firstname"] = workingEmp.firstname;
            dr["identity_no"] = workingEmp.identity_no;
            dr["pay_id"] = workingEmp.pay_id;
            dr["occupation"] = workingEmp.occupation;
            dr["appointed_date"] = workingEmp.appointed_date;
            dr["pay_id"] = workingEmp.pay_id;
            dr["tax_id"] = workingEmp.tax_id;
            dr["status"] = workingEmp.status;
            dr["basic_salary"] = workingEmp.basic_salary_tmp;
            dr["other_earnings1_descr"] = workingEmp.other_earnings1_descr_tmp;
            dr["other_earnings1_value"] = workingEmp.other_earnings1_value_tmp;
            dr["gross_pay"] = workingEmp.gross_pay_tmp;
            dr["net_pay"] = workingEmp.net_pay_tmp;
            dr["paye"] = workingEmp.paye_tmp;
            dr["uif"] = workingEmp.uif_tmp;
            dr["providend"] = workingEmp.providend_tmp;
            dr["other_deduction1_descr"] = workingEmp.other_deduction1_descr_tmp;
            dr["other_deduction1_value"] = workingEmp.other_deduction1_value_tmp;
            dr["total_deduction"] = workingEmp.total_deduction_tmp;
        }

        private void ultraButton6_Click(object sender, EventArgs e)
        {
            //Print payslip
            ultraPrintDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);

            ultraPrintPreviewDialog1.Document = ultraPrintDocument1;

            ultraPrintPreviewDialog1.Width = ultraGroupBox6.Width;
            ultraPrintPreviewDialog1.Height = ultraGroupBox6.Height;
            ultraPrintPreviewDialog1.ShowDialog();
            ultraPrintDocument1.Dispose();
        }

        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Bitmap memoryImage = new System.Drawing.Bitmap(this.ultraGroupBox6.Width, this.ultraGroupBox6.Height);
            ultraGroupBox6.DrawToBitmap(memoryImage, this.ultraGroupBox6.ClientRectangle);
            int x = ultraGroupBox6.Top;
            int y = ultraGroupBox6.Left;
            int width = ultraGroupBox6.Width;
            int height = ultraGroupBox6.Height;
            e.Graphics.DrawImage(memoryImage, x, y, width, height);
        }

        private void ultraButton7_Click(object sender, EventArgs e)
        {
            //delete entry from payroll
            DialogResult dialogResult = MessageBox.Show("Delete Employee from Payroll: " + ultraTextEditor156.Text + ", " + ultraTextEditor157.Text, "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                payrollBindingSource.RemoveCurrent();
                payrollTableAdapter.Update(dataSet1);
                employeeBindingSource.MoveFirst();
            }
            else if (dialogResult == DialogResult.No)
            {
                //revert with no action taken
            }

        }

        private void ultraButton8_Click(object sender, EventArgs e)
        {
            //Retrieve employee defaults - basically get payroll row from employee row
            //
            //Get to correct position in employee table (ID-based)


            int payrollpointer = payrollBindingSource.Position;
            // note: dr=employee drv, drp=payroll drv
            DataRowView drvp = (DataRowView)payrollBindingSource.Current;
            DataRow drp = (DataRow)drvp.Row;

            string prlID = drp["empID"].ToString();

            int itemFound = employeeBindingSource.Find("ID", prlID );
            employeeBindingSource.Position = itemFound;


             
            DataRowView drv = (DataRowView)employeeBindingSource.Current;
            DataRow dr = (DataRow)drv.Row;


            //drp["ID"] = dr["ID"];
            drp["lastname"] = dr["lastname"];
            drp["firstname"] = dr["firstname"];
            drp["identity_no"] = dr["identity_no"];
            drp["pay_id"] = dr["pay_id"];
            drp["occupation"] = dr["occupation"];
            drp["appointed_date"] = dr["appointed_date"];
            drp["tax_id"] = dr["tax_id"];
            drp["status"] = dr["status"];
            drp["basic_salary"] = dr["basic_salary_tmp"];
            drp["other_earnings1_value"] = dr["other_earnings1_value_tmp"];
            drp["other_earnings1_descr"] = dr["other_earnings1_descr_tmp"];
            drp["paye"] = dr["paye_tmp"];
            drp["uif"] = dr["uif_tmp"];
            drp["providend"] = dr["providend_tmp"];
            drp["other_deduction1_value"] = dr["other_deduction1_value_tmp"];
            drp["other_deduction1_descr"] = dr["other_deduction1_descr_tmp"];
            drp["gross_pay"] = dr["gross_pay_tmp"];
            drp["total_deduction"] = dr["total_deduction_tmp"];
            drp["net_pay"] = dr["net_pay_tmp"];
            drp["pay_date"] = dr["pay_date_tmp"];

            payrollTableAdapter.Update(dataSet1);
            payrollBindingSource.Position = payrollpointer;
            payrollBindingSource.ResetBindings(false);
            MessageBox.Show("Defaults retrieved for: " + dr["lastname"].ToString() + ", "+ dr["firstname"].ToString());
        }

        private void ultraButton9_Click(object sender, EventArgs e)
        {
            //Save screen display as employee defaults

            //Retrieve employee defaults - basically get payroll row from employee row
            //
            //Get to correct position in employee table (ID-based)


            int payrollpointer = payrollBindingSource.Position;
            // note: dr=employee drv, drp=payroll drv
            DataRowView drvp = (DataRowView)payrollBindingSource.Current;
            DataRow drp = (DataRow)drvp.Row;

            string prlID = drp["empID"].ToString();

            int itemFound = employeeBindingSource.Find("ID", prlID);
            employeeBindingSource.Position = itemFound;



            DataRowView drv = (DataRowView)employeeBindingSource.Current;
            DataRow dr = (DataRow)drv.Row;


            //drp["ID"] = dr["ID"];
            dr["lastname"] = ultraTextEditor156.Text;
            dr["firstname"] = ultraTextEditor157.Text;
            dr["pay_id"] = ultraTextEditor155.Text;
            dr["basic_salary_tmp"] = n2z(ultraMaskedEdit1.Value);
            dr["other_earnings1_value_tmp"] = n2z(ultraMaskedEdit2.Value);
            dr["other_earnings1_descr_tmp"] = ultraTextEditor8.Text;
            dr["paye_tmp"] = n2z(ultraMaskedEdit5.Value);
            dr["uif_tmp"] = n2z(ultraMaskedEdit6.Value);
            dr["providend_tmp"] = n2z(ultraMaskedEdit7.Value);
            dr["other_deduction1_value_tmp"] = n2z(ultraMaskedEdit8.Value);
            dr["other_deduction1_descr_tmp"] = ultraTextEditor10.Text;
            dr["gross_pay_tmp"] = n2z(ultraMaskedEdit3.Value);
            dr["total_deduction_tmp"] = n2z(ultraMaskedEdit9.Value);
            dr["net_pay_tmp"] = n2z(ultraMaskedEdit4.Value);

            //employeeTableAdapter.Update(dataSet1);
            employeeTableAdapter.Update(dataSet1.Employee);
            //payrollBindingSource.Position = payrollpointer;
            //payrollBindingSource.ResetBindings(false);
            MessageBox.Show("Defaults saved for: " + dr["lastname"].ToString() + ", " + dr["firstname"].ToString());


        }

        private void ultraButton10_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(dataSet1.Employee);
            payrollTableAdapter.Update(dataSet1.Payroll);
            MessageBox.Show("Payroll Data Saved");
        }

        private void ultraButton24_Click(object sender, EventArgs e)
        {
            if (payrollBindingSource.Count == 0) return;

            DialogResult dialogResult = MessageBox.Show("Save Payroll into month of ==>> " + ultraComboEditor2.Text + " <<== Data Storage?", "", MessageBoxButtons.YesNo);

            string whichmo = "_"+ultraComboEditor2.Text.Substring(0, 3);
            whichmo = whichmo.ToLower();

            if (dialogResult == DialogResult.Yes)
            {
                switch (ultraComboEditor2.Text)
                {
                    case "January":
                        pigeonUpdate(whichmo);
                        break;
                    case "February":
                        pigeonUpdate(whichmo);
                        break;
                    case "March":
                        pigeonUpdate(whichmo);
                        break;
                    case "April":
                        pigeonUpdate(whichmo);
                        break;
                    case "May":
                        pigeonUpdate(whichmo);
                        break;
                    case "June":
                        pigeonUpdate(whichmo);
                        break;
                    case "July":
                        pigeonUpdate(whichmo);
                        break;
                    case "August":
                        pigeonUpdate(whichmo);
                        break;
                    case "September":
                        pigeonUpdate(whichmo);
                        break;
                    case "October":
                        pigeonUpdate(whichmo);
                        break;
                    case "November":
                        pigeonUpdate(whichmo);
                        break;
                    case "December":
                        pigeonUpdate(whichmo);
                        break;
                    default:
                        {
                            MessageBox.Show("Cannot do. Selected month "+ ultraComboEditor2.Text+" is not a valid month!");
                            break;
                        }

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //revert with no action taken
            }
        }

        private void pigeonUpdate(string whichmo)
        {
            //loop through payrollbindingsource
            //locate employee in employee bindingsource
            //if found, update figures as per payrollbindingsource entries (mainly screen display) plus items like pay_date and pay_month

            payrollBindingSource.MoveFirst();

            for (int i = 0; i < payrollBindingSource.Count; i++)
            {

                int payrollpointer = payrollBindingSource.Position;

                // note: dr=employee drv, drp=payroll drv
                DataRowView drvp = (DataRowView)payrollBindingSource.Current;
                DataRow drp = (DataRow)drvp.Row;

                string prlID = drp["empID"].ToString();

                int itemFound = employeeBindingSource.Find("ID", prlID);
                employeeBindingSource.Position = itemFound;

                DataRowView drv = (DataRowView)employeeBindingSource.Current;
                DataRow dr = (DataRow)drv.Row;


                dr["basic_salary"+whichmo] = drp["basic_salary"];
                dr["other_earnings1_value"+whichmo] = drp["other_earnings1_value"];
                dr["other_earnings1_descr"+whichmo] = drp["other_earnings1_descr"];
                dr["paye"+whichmo] = drp["paye"];
                dr["uif"+whichmo] = drp["uif"];
                dr["providend"+whichmo] = drp["providend"];
                dr["other_deduction1_value"+whichmo] = drp["other_deduction1_value"];
                dr["other_deduction1_descr"+whichmo] = drp["other_deduction1_descr"];
                dr["gross_pay"+whichmo] = drp["gross_pay"];
                dr["total_deduction"+whichmo] = drp["total_deduction"];
                dr["net_pay"+whichmo] = drp["net_pay"];
                dr["pay_date"+whichmo] = ultraDateTimeEditor2.Value;

                //MessageBox.Show("Paydate: " + ultraDateTimeEditor2.Value.ToString());

                // next row in payroll
                payrollBindingSource.MoveNext();
                employeeTableAdapter.Update(dataSet1.Employee);
            }
            MessageBox.Show("Payroll saved into month of: " + whichmo);


        }

        private void ultraButton15_Click(object sender, EventArgs e)
        {
            frmPaySchedule frm = new frmPaySchedule();
            frm.Show();
        }

        private void ultraButton16_Click(object sender, EventArgs e)
        {
            frmPayrollSummary frm = new frmPayrollSummary();
            frm.Show();
        }

        private void ultraButton22_Click(object sender, EventArgs e)
        {
            frmViewTaxTables frm = new frmViewTaxTables();
            frm.Show();
        }

        private void ultraButton21_Click(object sender, EventArgs e)
        {
            //delete entry from payroll
            DialogResult dialogResult = MessageBox.Show("Apply 1% Deduction to Payroll Employee: " + ultraTextEditor156.Text + ", " + ultraTextEditor157.Text, "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //payrollBindingSource.RemoveCurrent();
                //payrollTableAdapter.Update(dataSet1);
                //employeeBindingSource.MoveFirst();

                ultraMaskedEdit6.Value = n2z( .01 * Convert.ToDouble(ultraMaskedEdit1.Value));

                //payrollTableAdapter.Update(dataSet1);

            }
            else if (dialogResult == DialogResult.No)
            {
                //revert with no action taken
            }
        }

        private void ultraButton14_Click(object sender, EventArgs e)
        {
            frmSalarySlips frm = new frmSalarySlips();
            frm.Show();
        }
    }
}