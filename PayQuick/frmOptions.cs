using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayQuick
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            this.optionsTableAdapter.Fill(this.dataSet1.Options);
            if (optionsBindingSource.Count == 0) optionsBindingSource.AddNew();
            ultraComboEditor1.Enabled = true;
            if (ultraComboEditor2.Text == "Weekly") ultraComboEditor1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            optionsBindingSource.EndEdit();
            optionsTableAdapter.Update(dataSet1.Options);
            MessageBox.Show("QuickPay Options Saved");
            this.Close();
        }

        private void ultraComboEditor2_ValueChanged(object sender, EventArgs e)
        {
            ultraComboEditor1.Enabled = true;
            if (ultraComboEditor2.Text == "Weekly") ultraComboEditor1.Enabled = false;
        }
    }
}
