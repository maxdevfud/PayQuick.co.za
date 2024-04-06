namespace PayQuick
{
    partial class frmPaySchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaySchedule));
            this.PayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new PayQuick.DataSet1();
            this.PayrollTableAdapter = new PayQuick.DataSet1TableAdapters.PayrollTableAdapter();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.optionsTableAdapter = new PayQuick.DataSet1TableAdapters.OptionsTableAdapter();
            this.tableAdapterManager = new PayQuick.DataSet1TableAdapters.TableAdapterManager();
            this.employerTableAdapter = new PayQuick.DataSet1TableAdapters.EmployerTableAdapter();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report1 = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayrollBindingSource
            // 
            this.PayrollBindingSource.DataMember = "Payroll";
            this.PayrollBindingSource.DataSource = this.DataSet1;
            this.PayrollBindingSource.Sort = "lastname";
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PayrollTableAdapter
            // 
            this.PayrollTableAdapter.ClearBeforeFill = true;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.DataSet1;
            // 
            // optionsTableAdapter
            // 
            this.optionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = this.employerTableAdapter;
            this.tableAdapterManager.OptionsTableAdapter = this.optionsTableAdapter;
            this.tableAdapterManager.PAYEtablesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = this.PayrollTableAdapter;
            this.tableAdapterManager.UpdateOrder = PayQuick.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.DataSet1;
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // frmPaySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 526);
            this.Name = "frmPaySchedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Schedule";
            this.Load += new System.EventHandler(this.frmPaySchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PayrollBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PayrollTableAdapter PayrollTableAdapter;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private DataSet1TableAdapters.OptionsTableAdapter optionsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.EmployerTableAdapter employerTableAdapter;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private FastReport.Report report1;
    }
}