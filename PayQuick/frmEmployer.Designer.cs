namespace PayQuick
{
    partial class frmEmployer
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label sdlLabel;
            System.Windows.Forms.Label uifLabel;
            System.Windows.Forms.Label payeLabel;
            System.Windows.Forms.Label addr4Label;
            System.Windows.Forms.Label addr3Label;
            System.Windows.Forms.Label addr2Label;
            System.Windows.Forms.Label addr1Label;
            System.Windows.Forms.Label nameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.employerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PayQuick.DataSet1();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.sdlTextBox = new System.Windows.Forms.TextBox();
            this.uifTextBox = new System.Windows.Forms.TextBox();
            this.addr4TextBox = new System.Windows.Forms.TextBox();
            this.addr3TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.payeTextBox = new System.Windows.Forms.TextBox();
            this.addr2TextBox = new System.Windows.Forms.TextBox();
            this.addr1TextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employerTableAdapter = new PayQuick.DataSet1TableAdapters.EmployerTableAdapter();
            this.tableAdapterManager = new PayQuick.DataSet1TableAdapters.TableAdapterManager();
            this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            sdlLabel = new System.Windows.Forms.Label();
            uifLabel = new System.Windows.Forms.Label();
            payeLabel = new System.Windows.Forms.Label();
            addr4Label = new System.Windows.Forms.Label();
            addr3Label = new System.Windows.Forms.Label();
            addr2Label = new System.Windows.Forms.Label();
            addr1Label = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(70, 388);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 67;
            label3.Text = "End:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 354);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 66;
            label2.Text = "Payroll Starting:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(68, 224);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 63;
            emailLabel.Text = "Email";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(38, 199);
            telLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(63, 13);
            telLabel.TabIndex = 61;
            telLabel.Text = "Telephones";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(21, 250);
            contactLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(80, 13);
            contactLabel.TabIndex = 59;
            contactLabel.Text = "Contact Person";
            // 
            // sdlLabel
            // 
            sdlLabel.AutoSize = true;
            sdlLabel.Location = new System.Drawing.Point(51, 325);
            sdlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sdlLabel.Name = "sdlLabel";
            sdlLabel.Size = new System.Drawing.Size(51, 13);
            sdlLabel.TabIndex = 57;
            sdlLabel.Text = "SDL Ref.";
            // 
            // uifLabel
            // 
            uifLabel.AutoSize = true;
            uifLabel.Location = new System.Drawing.Point(56, 300);
            uifLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            uifLabel.Name = "uifLabel";
            uifLabel.Size = new System.Drawing.Size(47, 13);
            uifLabel.TabIndex = 55;
            uifLabel.Text = "UIF Ref.";
            // 
            // payeLabel
            // 
            payeLabel.AutoSize = true;
            payeLabel.Location = new System.Drawing.Point(44, 275);
            payeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            payeLabel.Name = "payeLabel";
            payeLabel.Size = new System.Drawing.Size(58, 13);
            payeLabel.TabIndex = 53;
            payeLabel.Text = "PAYE Ref.";
            // 
            // addr4Label
            // 
            addr4Label.AutoSize = true;
            addr4Label.Location = new System.Drawing.Point(37, 174);
            addr4Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addr4Label.Name = "addr4Label";
            addr4Label.Size = new System.Drawing.Size(64, 13);
            addr4Label.TabIndex = 51;
            addr4Label.Text = "Postal Code";
            // 
            // addr3Label
            // 
            addr3Label.AutoSize = true;
            addr3Label.Location = new System.Drawing.Point(53, 149);
            addr3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addr3Label.Name = "addr3Label";
            addr3Label.Size = new System.Drawing.Size(49, 13);
            addr3Label.TabIndex = 49;
            addr3Label.Text = "Province";
            // 
            // addr2Label
            // 
            addr2Label.AutoSize = true;
            addr2Label.Location = new System.Drawing.Point(39, 124);
            addr2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addr2Label.Name = "addr2Label";
            addr2Label.Size = new System.Drawing.Size(63, 13);
            addr2Label.TabIndex = 47;
            addr2Label.Text = "Suburb/City";
            // 
            // addr1Label
            // 
            addr1Label.AutoSize = true;
            addr1Label.Location = new System.Drawing.Point(45, 98);
            addr1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addr1Label.Name = "addr1Label";
            addr1Label.Size = new System.Drawing.Size(58, 13);
            addr1Label.TabIndex = 45;
            addr1Label.Text = "Street/Box";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 73);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(81, 13);
            nameLabel.TabIndex = 43;
            nameLabel.Text = "Employer Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 49);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employer Details";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "tel", true));
            this.telTextBox.Location = new System.Drawing.Point(107, 197);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(224, 20);
            this.telTextBox.TabIndex = 62;
            // 
            // employerBindingSource1
            // 
            this.employerBindingSource1.DataMember = "Employer";
            this.employerBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(107, 247);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(224, 20);
            this.contactTextBox.TabIndex = 60;
            // 
            // sdlTextBox
            // 
            this.sdlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "sdl_id", true));
            this.sdlTextBox.Location = new System.Drawing.Point(107, 323);
            this.sdlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sdlTextBox.Name = "sdlTextBox";
            this.sdlTextBox.Size = new System.Drawing.Size(224, 20);
            this.sdlTextBox.TabIndex = 58;
            // 
            // uifTextBox
            // 
            this.uifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "uif_id", true));
            this.uifTextBox.Location = new System.Drawing.Point(107, 297);
            this.uifTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uifTextBox.Name = "uifTextBox";
            this.uifTextBox.Size = new System.Drawing.Size(224, 20);
            this.uifTextBox.TabIndex = 56;
            // 
            // addr4TextBox
            // 
            this.addr4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "addr4", true));
            this.addr4TextBox.Location = new System.Drawing.Point(107, 172);
            this.addr4TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addr4TextBox.Name = "addr4TextBox";
            this.addr4TextBox.Size = new System.Drawing.Size(304, 20);
            this.addr4TextBox.TabIndex = 52;
            // 
            // addr3TextBox
            // 
            this.addr3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "addr3", true));
            this.addr3TextBox.Location = new System.Drawing.Point(107, 146);
            this.addr3TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addr3TextBox.Name = "addr3TextBox";
            this.addr3TextBox.Size = new System.Drawing.Size(304, 20);
            this.addr3TextBox.TabIndex = 50;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(107, 222);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 20);
            this.emailTextBox.TabIndex = 64;
            // 
            // payeTextBox
            // 
            this.payeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "paye_id", true));
            this.payeTextBox.Location = new System.Drawing.Point(107, 272);
            this.payeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.payeTextBox.Name = "payeTextBox";
            this.payeTextBox.Size = new System.Drawing.Size(224, 20);
            this.payeTextBox.TabIndex = 54;
            // 
            // addr2TextBox
            // 
            this.addr2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "addr2", true));
            this.addr2TextBox.Location = new System.Drawing.Point(107, 121);
            this.addr2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addr2TextBox.Name = "addr2TextBox";
            this.addr2TextBox.Size = new System.Drawing.Size(304, 20);
            this.addr2TextBox.TabIndex = 48;
            // 
            // addr1TextBox
            // 
            this.addr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "addr1", true));
            this.addr1TextBox.Location = new System.Drawing.Point(107, 96);
            this.addr1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addr1TextBox.Name = "addr1TextBox";
            this.addr1TextBox.Size = new System.Drawing.Size(304, 20);
            this.addr1TextBox.TabIndex = 46;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource1, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(107, 71);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(304, 20);
            this.nameTextBox.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 428);
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
            this.button1.Location = new System.Drawing.Point(284, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = this.employerTableAdapter;
            this.tableAdapterManager.PAYEtablesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.OptionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayQuick.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ultraDateTimeEditor1
            // 
            this.ultraDateTimeEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employerBindingSource1, "currentstart", true));
            this.ultraDateTimeEditor1.Location = new System.Drawing.Point(107, 350);
            this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
            this.ultraDateTimeEditor1.Size = new System.Drawing.Size(96, 21);
            this.ultraDateTimeEditor1.TabIndex = 68;
            // 
            // ultraDateTimeEditor2
            // 
            this.ultraDateTimeEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employerBindingSource1, "currentend", true));
            this.ultraDateTimeEditor2.Location = new System.Drawing.Point(107, 381);
            this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
            this.ultraDateTimeEditor2.Size = new System.Drawing.Size(96, 21);
            this.ultraDateTimeEditor2.TabIndex = 69;
            // 
            // frmEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 470);
            this.Controls.Add(this.ultraDateTimeEditor2);
            this.Controls.Add(this.ultraDateTimeEditor1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.sdlTextBox);
            this.Controls.Add(this.uifTextBox);
            this.Controls.Add(this.addr4TextBox);
            this.Controls.Add(this.addr3TextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(contactLabel);
            this.Controls.Add(sdlLabel);
            this.Controls.Add(uifLabel);
            this.Controls.Add(payeLabel);
            this.Controls.Add(this.payeTextBox);
            this.Controls.Add(addr4Label);
            this.Controls.Add(addr3Label);
            this.Controls.Add(addr2Label);
            this.Controls.Add(this.addr2TextBox);
            this.Controls.Add(addr1Label);
            this.Controls.Add(this.addr1TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmEmployer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEmployer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox sdlTextBox;
        private System.Windows.Forms.TextBox uifTextBox;
        private System.Windows.Forms.TextBox addr4TextBox;
        private System.Windows.Forms.TextBox addr3TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox payeTextBox;
        private System.Windows.Forms.TextBox addr2TextBox;
        private System.Windows.Forms.TextBox addr1TextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employerBindingSource1;
        private DataSet1TableAdapters.EmployerTableAdapter employerTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
    }
}