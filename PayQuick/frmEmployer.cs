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
    public partial class frmEmployer : Form
    {
        public frmEmployer()
        {
            InitializeComponent();
        }

        private void frmEmployer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employer' table. You can move, or remove it, as needed.
            this.employerTableAdapter.Fill(this.dataSet1.Employer);
            if (employerBindingSource1.Count == 0) employerBindingSource1.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validate();
            employerBindingSource1.EndEdit();
            //employerTableAdapter.Update(dataSet1);
            employerTableAdapter.Update(dataSet1.Employer);
            MessageBox.Show("Employer Details Saved");
            this.Close();
        }
    }
}
