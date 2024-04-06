namespace PayQuick
{
    partial class frmPayrollSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label basic_salaryLabel1;
            System.Windows.Forms.Label other_earnings1_valueLabel;
            System.Windows.Forms.Label gross_payLabel;
            System.Windows.Forms.Label payeLabel;
            System.Windows.Forms.Label uifLabel;
            System.Windows.Forms.Label providendLabel;
            System.Windows.Forms.Label other_deduction1_valueLabel;
            System.Windows.Forms.Label total_deductionLabel;
            System.Windows.Forms.Label net_payLabel;
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraMaskedEdit9 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit8 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit7 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit6 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit5 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit4 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit3 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit2 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraMaskedEdit1 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_dateLabel1 = new System.Windows.Forms.Label();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PayQuick.DataSet1();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTableAdapter = new PayQuick.DataSet1TableAdapters.PayrollTableAdapter();
            this.tableAdapterManager = new PayQuick.DataSet1TableAdapters.TableAdapterManager();
            this.employerTableAdapter = new PayQuick.DataSet1TableAdapters.EmployerTableAdapter();
            this.optionsTableAdapter = new PayQuick.DataSet1TableAdapters.OptionsTableAdapter();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            basic_salaryLabel1 = new System.Windows.Forms.Label();
            other_earnings1_valueLabel = new System.Windows.Forms.Label();
            gross_payLabel = new System.Windows.Forms.Label();
            payeLabel = new System.Windows.Forms.Label();
            uifLabel = new System.Windows.Forms.Label();
            providendLabel = new System.Windows.Forms.Label();
            other_deduction1_valueLabel = new System.Windows.Forms.Label();
            total_deductionLabel = new System.Windows.Forms.Label();
            net_payLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basic_salaryLabel1
            // 
            basic_salaryLabel1.AutoSize = true;
            basic_salaryLabel1.Location = new System.Drawing.Point(287, 151);
            basic_salaryLabel1.Name = "basic_salaryLabel1";
            basic_salaryLabel1.Size = new System.Drawing.Size(68, 13);
            basic_salaryLabel1.TabIndex = 1;
            basic_salaryLabel1.Text = "Basic Salary:";
            // 
            // other_earnings1_valueLabel
            // 
            other_earnings1_valueLabel.AutoSize = true;
            other_earnings1_valueLabel.Location = new System.Drawing.Point(275, 193);
            other_earnings1_valueLabel.Name = "other_earnings1_valueLabel";
            other_earnings1_valueLabel.Size = new System.Drawing.Size(80, 13);
            other_earnings1_valueLabel.TabIndex = 2;
            other_earnings1_valueLabel.Text = "Other Earnings:";
            // 
            // gross_payLabel
            // 
            gross_payLabel.AutoSize = true;
            gross_payLabel.Location = new System.Drawing.Point(270, 235);
            gross_payLabel.Name = "gross_payLabel";
            gross_payLabel.Size = new System.Drawing.Size(85, 13);
            gross_payLabel.TabIndex = 4;
            gross_payLabel.Text = "Total Gross Pay:";
            // 
            // payeLabel
            // 
            payeLabel.AutoSize = true;
            payeLabel.Location = new System.Drawing.Point(290, 277);
            payeLabel.Name = "payeLabel";
            payeLabel.Size = new System.Drawing.Size(65, 13);
            payeLabel.TabIndex = 6;
            payeLabel.Text = "Total PAYE:";
            // 
            // uifLabel
            // 
            uifLabel.AutoSize = true;
            uifLabel.Location = new System.Drawing.Point(301, 319);
            uifLabel.Name = "uifLabel";
            uifLabel.Size = new System.Drawing.Size(54, 13);
            uifLabel.TabIndex = 8;
            uifLabel.Text = "Total UIF:";
            // 
            // providendLabel
            // 
            providendLabel.AutoSize = true;
            providendLabel.Location = new System.Drawing.Point(273, 361);
            providendLabel.Name = "providendLabel";
            providendLabel.Size = new System.Drawing.Size(82, 13);
            providendLabel.TabIndex = 10;
            providendLabel.Text = "Total Provident:";
            // 
            // other_deduction1_valueLabel
            // 
            other_deduction1_valueLabel.AutoSize = true;
            other_deduction1_valueLabel.Location = new System.Drawing.Point(235, 403);
            other_deduction1_valueLabel.Name = "other_deduction1_valueLabel";
            other_deduction1_valueLabel.Size = new System.Drawing.Size(120, 13);
            other_deduction1_valueLabel.TabIndex = 12;
            other_deduction1_valueLabel.Text = "Total Other Deductions:";
            // 
            // total_deductionLabel
            // 
            total_deductionLabel.AutoSize = true;
            total_deductionLabel.Location = new System.Drawing.Point(234, 445);
            total_deductionLabel.Name = "total_deductionLabel";
            total_deductionLabel.Size = new System.Drawing.Size(121, 13);
            total_deductionLabel.TabIndex = 14;
            total_deductionLabel.Text = "Total Gross Deductions:";
            // 
            // net_payLabel
            // 
            net_payLabel.AutoSize = true;
            net_payLabel.Location = new System.Drawing.Point(299, 487);
            net_payLabel.Name = "net_payLabel";
            net_payLabel.Size = new System.Drawing.Size(56, 13);
            net_payLabel.TabIndex = 16;
            net_payLabel.Text = "NET PAY:";
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit9);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit8);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit7);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit6);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit5);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit4);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit3);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit2);
            this.ultraGroupBox1.Controls.Add(this.ultraMaskedEdit1);
            this.ultraGroupBox1.Controls.Add(this.label1);
            this.ultraGroupBox1.Controls.Add(this.pay_dateLabel1);
            this.ultraGroupBox1.Controls.Add(this.nameLabel1);
            this.ultraGroupBox1.Controls.Add(net_payLabel);
            this.ultraGroupBox1.Controls.Add(total_deductionLabel);
            this.ultraGroupBox1.Controls.Add(other_deduction1_valueLabel);
            this.ultraGroupBox1.Controls.Add(providendLabel);
            this.ultraGroupBox1.Controls.Add(uifLabel);
            this.ultraGroupBox1.Controls.Add(payeLabel);
            this.ultraGroupBox1.Controls.Add(gross_payLabel);
            this.ultraGroupBox1.Controls.Add(other_earnings1_valueLabel);
            this.ultraGroupBox1.Controls.Add(basic_salaryLabel1);
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(787, 517);
            this.ultraGroupBox1.TabIndex = 0;
            // 
            // ultraMaskedEdit9
            // 
            appearance1.FontData.BoldAsString = "True";
            appearance1.FontData.SizeInPoints = 16F;
            appearance1.TextHAlignAsString = "Right";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit9.Appearance = appearance1;
            this.ultraMaskedEdit9.AutoSize = false;
            this.ultraMaskedEdit9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit9.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit9.Enabled = false;
            this.ultraMaskedEdit9.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit9.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit9.Location = new System.Drawing.Point(370, 475);
            this.ultraMaskedEdit9.Name = "ultraMaskedEdit9";
            this.ultraMaskedEdit9.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit9.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit9.TabIndex = 40;
            // 
            // ultraMaskedEdit8
            // 
            appearance2.FontData.BoldAsString = "True";
            appearance2.FontData.SizeInPoints = 16F;
            appearance2.TextHAlignAsString = "Right";
            appearance2.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit8.Appearance = appearance2;
            this.ultraMaskedEdit8.AutoSize = false;
            this.ultraMaskedEdit8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit8.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit8.Enabled = false;
            this.ultraMaskedEdit8.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit8.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit8.Location = new System.Drawing.Point(370, 433);
            this.ultraMaskedEdit8.Name = "ultraMaskedEdit8";
            this.ultraMaskedEdit8.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit8.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit8.TabIndex = 39;
            // 
            // ultraMaskedEdit7
            // 
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.SizeInPoints = 16F;
            appearance3.TextHAlignAsString = "Right";
            appearance3.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit7.Appearance = appearance3;
            this.ultraMaskedEdit7.AutoSize = false;
            this.ultraMaskedEdit7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit7.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit7.Enabled = false;
            this.ultraMaskedEdit7.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit7.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit7.Location = new System.Drawing.Point(370, 391);
            this.ultraMaskedEdit7.Name = "ultraMaskedEdit7";
            this.ultraMaskedEdit7.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit7.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit7.TabIndex = 38;
            // 
            // ultraMaskedEdit6
            // 
            appearance4.FontData.BoldAsString = "True";
            appearance4.FontData.SizeInPoints = 16F;
            appearance4.TextHAlignAsString = "Right";
            appearance4.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit6.Appearance = appearance4;
            this.ultraMaskedEdit6.AutoSize = false;
            this.ultraMaskedEdit6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit6.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit6.Enabled = false;
            this.ultraMaskedEdit6.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit6.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit6.Location = new System.Drawing.Point(370, 349);
            this.ultraMaskedEdit6.Name = "ultraMaskedEdit6";
            this.ultraMaskedEdit6.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit6.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit6.TabIndex = 37;
            // 
            // ultraMaskedEdit5
            // 
            appearance5.FontData.BoldAsString = "True";
            appearance5.FontData.SizeInPoints = 16F;
            appearance5.TextHAlignAsString = "Right";
            appearance5.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit5.Appearance = appearance5;
            this.ultraMaskedEdit5.AutoSize = false;
            this.ultraMaskedEdit5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit5.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit5.Enabled = false;
            this.ultraMaskedEdit5.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit5.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit5.Location = new System.Drawing.Point(370, 307);
            this.ultraMaskedEdit5.Name = "ultraMaskedEdit5";
            this.ultraMaskedEdit5.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit5.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit5.TabIndex = 36;
            // 
            // ultraMaskedEdit4
            // 
            appearance6.FontData.BoldAsString = "True";
            appearance6.FontData.SizeInPoints = 16F;
            appearance6.TextHAlignAsString = "Right";
            appearance6.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit4.Appearance = appearance6;
            this.ultraMaskedEdit4.AutoSize = false;
            this.ultraMaskedEdit4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit4.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit4.Enabled = false;
            this.ultraMaskedEdit4.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit4.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit4.Location = new System.Drawing.Point(370, 265);
            this.ultraMaskedEdit4.Name = "ultraMaskedEdit4";
            this.ultraMaskedEdit4.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit4.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit4.TabIndex = 35;
            // 
            // ultraMaskedEdit3
            // 
            appearance7.FontData.BoldAsString = "True";
            appearance7.FontData.SizeInPoints = 16F;
            appearance7.TextHAlignAsString = "Right";
            appearance7.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit3.Appearance = appearance7;
            this.ultraMaskedEdit3.AutoSize = false;
            this.ultraMaskedEdit3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit3.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit3.Enabled = false;
            this.ultraMaskedEdit3.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit3.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit3.Location = new System.Drawing.Point(370, 223);
            this.ultraMaskedEdit3.Name = "ultraMaskedEdit3";
            this.ultraMaskedEdit3.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit3.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit3.TabIndex = 34;
            // 
            // ultraMaskedEdit2
            // 
            appearance8.FontData.BoldAsString = "True";
            appearance8.FontData.SizeInPoints = 16F;
            appearance8.TextHAlignAsString = "Right";
            appearance8.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit2.Appearance = appearance8;
            this.ultraMaskedEdit2.AutoSize = false;
            this.ultraMaskedEdit2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit2.Enabled = false;
            this.ultraMaskedEdit2.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit2.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit2.Location = new System.Drawing.Point(370, 181);
            this.ultraMaskedEdit2.Name = "ultraMaskedEdit2";
            this.ultraMaskedEdit2.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit2.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit2.TabIndex = 33;
            // 
            // ultraMaskedEdit1
            // 
            appearance9.FontData.BoldAsString = "True";
            appearance9.FontData.SizeInPoints = 16F;
            appearance9.TextHAlignAsString = "Right";
            appearance9.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit1.Appearance = appearance9;
            this.ultraMaskedEdit1.AutoSize = false;
            this.ultraMaskedEdit1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit1.Enabled = false;
            this.ultraMaskedEdit1.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit1.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit1.Location = new System.Drawing.Point(370, 139);
            this.ultraMaskedEdit1.Name = "ultraMaskedEdit1";
            this.ultraMaskedEdit1.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit1.Size = new System.Drawing.Size(140, 36);
            this.ultraMaskedEdit1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Payroll Summary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay_dateLabel1
            // 
            this.pay_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "pay_date", true));
            this.pay_dateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_dateLabel1.Location = new System.Drawing.Point(0, 96);
            this.pay_dateLabel1.Name = "pay_dateLabel1";
            this.pay_dateLabel1.Size = new System.Drawing.Size(784, 38);
            this.pay_dateLabel1.TabIndex = 29;
            this.pay_dateLabel1.Text = "label1";
            this.pay_dateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "name", true));
            this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nameLabel1.Location = new System.Drawing.Point(3, 3);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(781, 45);
            this.nameLabel1.TabIndex = 28;
            this.nameLabel1.Text = "label1";
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.dataSet1;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "Payroll";
            this.payrollBindingSource.DataSource = this.dataSet1;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = this.employerTableAdapter;
            this.tableAdapterManager.OptionsTableAdapter = this.optionsTableAdapter;
            this.tableAdapterManager.PAYEtablesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = this.payrollTableAdapter;
            this.tableAdapterManager.UpdateOrder = PayQuick.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // optionsTableAdapter
            // 
            this.optionsTableAdapter.ClearBeforeFill = true;
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(421, 544);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(75, 23);
            this.ultraButton1.TabIndex = 26;
            this.ultraButton1.Text = "Print";
            // 
            // ultraButton2
            // 
            this.ultraButton2.Location = new System.Drawing.Point(530, 544);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(75, 23);
            this.ultraButton2.TabIndex = 27;
            this.ultraButton2.Text = "Close";
            this.ultraButton2.Click += new System.EventHandler(this.ultraButton2_Click);
            // 
            // frmPayrollSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 621);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.ultraButton1);
            this.Name = "frmPayrollSummary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Summary";
            this.Load += new System.EventHandler(this.frmPayrollSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private DataSet1TableAdapters.PayrollTableAdapter payrollTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private DataSet1TableAdapters.EmployerTableAdapter employerTableAdapter;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private System.Windows.Forms.Label nameLabel1;
        private DataSet1TableAdapters.OptionsTableAdapter optionsTableAdapter;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private System.Windows.Forms.Label pay_dateLabel1;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit9;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit8;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit7;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit6;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit5;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit4;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit3;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit2;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit1;
    }
}