using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallComponents.Interaction.WinForms;

namespace PayQuick
{
    public partial class frmViewTaxTables : Form
    {
        public frmViewTaxTables()
        {
            InitializeComponent();
        }

        private void frmViewTaxTables_Load(object sender, EventArgs e)
        {
            //System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            //{
            //    document1.Open(dialog.FileName);
            //}
            document1.Open("Sars-2018.pdf");
            documentViewer2.Show();
        }
    }
}
