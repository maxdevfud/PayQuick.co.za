namespace PayQuick
{
    partial class frmOptions
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
            Infragistics.Win.ValueListItem valueListItem27 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem28 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem7 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem8 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem9 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem10 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem11 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem12 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem13 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem14 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem15 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new PayQuick.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PayQuick.DataSet1TableAdapters.TableAdapterManager();
            this.optionsTableAdapter = new PayQuick.DataSet1TableAdapters.OptionsTableAdapter();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraComboEditor2 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel22 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel21 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboEditor1 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 49);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuickPay Options";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 205);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 31);
            this.button2.TabIndex = 42;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(153, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.OptionsTableAdapter = this.optionsTableAdapter;
            this.tableAdapterManager.PAYEtablesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayQuick.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // optionsTableAdapter
            // 
            this.optionsTableAdapter.ClearBeforeFill = true;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.dataSet1;
            // 
            // ultraDateTimeEditor2
            // 
            this.ultraDateTimeEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.optionsBindingSource, "pay_date", true));
            this.ultraDateTimeEditor2.DateTime = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            this.ultraDateTimeEditor2.Location = new System.Drawing.Point(128, 67);
            this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
            this.ultraDateTimeEditor2.Size = new System.Drawing.Size(107, 21);
            this.ultraDateTimeEditor2.TabIndex = 69;
            this.ultraDateTimeEditor2.Value = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            // 
            // ultraComboEditor2
            // 
            this.ultraComboEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.optionsBindingSource, "pay_cycle", true));
            valueListItem27.CheckState = System.Windows.Forms.CheckState.Checked;
            valueListItem27.DataValue = "Monthly";
            valueListItem27.DisplayText = "Monthly";
            valueListItem28.DataValue = "Weekly";
            valueListItem28.DisplayText = "Weekly";
            this.ultraComboEditor2.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem27,
            valueListItem28});
            this.ultraComboEditor2.Location = new System.Drawing.Point(128, 105);
            this.ultraComboEditor2.Name = "ultraComboEditor2";
            this.ultraComboEditor2.Size = new System.Drawing.Size(107, 21);
            this.ultraComboEditor2.TabIndex = 68;
            this.ultraComboEditor2.ValueChanged += new System.EventHandler(this.ultraComboEditor2_ValueChanged);
            // 
            // ultraLabel22
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraLabel22.Appearance = appearance1;
            this.ultraLabel22.Location = new System.Drawing.Point(66, 69);
            this.ultraLabel22.Name = "ultraLabel22";
            this.ultraLabel22.Size = new System.Drawing.Size(56, 17);
            this.ultraLabel22.TabIndex = 67;
            this.ultraLabel22.Text = "Pay date:";
            // 
            // ultraLabel21
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabel21.Appearance = appearance2;
            this.ultraLabel21.Location = new System.Drawing.Point(48, 108);
            this.ultraLabel21.Name = "ultraLabel21";
            this.ultraLabel21.Size = new System.Drawing.Size(74, 14);
            this.ultraLabel21.TabIndex = 66;
            this.ultraLabel21.Text = "Payroll Type:";
            // 
            // ultraComboEditor1
            // 
            this.ultraComboEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.optionsBindingSource, "current_month", true));
            valueListItem3.DataValue = "January";
            valueListItem4.DataValue = "February";
            valueListItem5.DataValue = "March";
            valueListItem6.DataValue = "April";
            valueListItem7.DataValue = "May";
            valueListItem8.DataValue = "June";
            valueListItem9.DataValue = "July";
            valueListItem10.DataValue = "August";
            valueListItem11.DataValue = "September";
            valueListItem12.DataValue = "October";
            valueListItem13.DataValue = "November";
            valueListItem14.DataValue = "December";
            valueListItem15.DataValue = "Bonus";
            this.ultraComboEditor1.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4,
            valueListItem5,
            valueListItem6,
            valueListItem7,
            valueListItem8,
            valueListItem9,
            valueListItem10,
            valueListItem11,
            valueListItem12,
            valueListItem13,
            valueListItem14,
            valueListItem15});
            this.ultraComboEditor1.Location = new System.Drawing.Point(128, 140);
            this.ultraComboEditor1.Name = "ultraComboEditor1";
            this.ultraComboEditor1.Size = new System.Drawing.Size(107, 21);
            this.ultraComboEditor1.TabIndex = 71;
            // 
            // ultraLabel1
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel1.Appearance = appearance3;
            this.ultraLabel1.Location = new System.Drawing.Point(61, 141);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(61, 18);
            this.ultraLabel1.TabIndex = 70;
            this.ultraLabel1.Text = "Month of:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 267);
            this.Controls.Add(this.ultraComboEditor1);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraDateTimeEditor2);
            this.Controls.Add(this.ultraComboEditor2);
            this.Controls.Add(this.ultraLabel22);
            this.Controls.Add(this.ultraLabel21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private DataSet1TableAdapters.OptionsTableAdapter optionsTableAdapter;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel22;
        private Infragistics.Win.Misc.UltraLabel ultraLabel21;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}