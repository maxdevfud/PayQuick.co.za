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
    public partial class frmRegisterPayQuick : Form
    {
        public frmRegisterPayQuick()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtRegisterStatus.Text == "NOT REGISTERED")
            {
                MessageBox.Show("PayQuick is not registered. Sorry, cannot continue.");
            }
            else
            {
                this.Close();
                try
                {
                    tLock1.InsertActiveCodeInFile(txtActivationCode.Text);
                    bool reg = tLock1.CheckRegistration();
                    switch (reg)
                    {
                        case true:
                            {
                                //Form2 frm = new Form2();
                                //frm.ShowDialog();
                                txtRegisterStatus.Text = "NOT REGISTERED";
                            }
                            break;
                        case false:
                            txtRegisterStatus.Text = "NOT REGISTERED";
                            break;
                    }
                }
                catch
                {
                    tLock1.Reset();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterStatus.Text == "REGISTERED")
            {
                MessageBox.Show("PayQuick already Registered.");
            }
            else
            {
                //if (a == string.Empty)
                string a = txtSerial.Text;
                string b = txtActivationCode.Text;

                //MessageBox.Show(txtRegisterStatus.Text);
                //MessageBox.Show(a);

                if ((txtRegisterStatus.Text == "NOT REGISTERED") && !((a == string.Empty) | (b == string.Empty)))
                  
                {

                    try
                    {
                        tLock1.InsertActiveCodeInFile(txtActivationCode.Text);
                        bool reg = tLock1.CheckRegistration();
                        switch (reg)
                        {
                            case true:
                                txtRegisterStatus.Text = "REGISTERED";
                                break;
                            case false:
                                txtRegisterStatus.Text = "NOT REGISTERED";
                                break;
                        }
                    }
                    catch
                    {
                        tLock1.Reset();
                    }
                    MessageBox.Show("Registration successful! You may now continue.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration No. is empty. Email contact details and Serial No. to: info@betterpracticemanagement.co.za");
                }
            }
        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {
            if (txtRegisterStatus.Text == "REGISTERED")
            {
                try
                {
                    tLock1.Reset();
                    bool reg = tLock1.CheckRegistration();
                    switch (reg)
                    {
                        case true:
                            txtRegisterStatus.Text = "REGISTERED";
                            break;
                        case false:
                            txtRegisterStatus.Text = "NOT REGISTERED";
                            break;
                    }
                }
                catch
                {
                    tLock1.Reset();
                }
                txtActivationCode.Text = "";
                txtSerial.Text = "";
                preloader();
                MessageBox.Show("PayQuick has successfully been DEREGISTERED.");
            }
            else
            {
                MessageBox.Show("Payquick is not already not registered to run on this computer.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterPayQuick_Load(object sender, EventArgs e)
        {
            preloader();
        }

        private void preloader()
        {
            tLock1.ActiveFileName = "YouractivefileName";
            tLock1.LockFilePath = QALock.TLockFilePath.CurrentDir;
            tLock1.SerialFileName = "YourserialfileName";
            tLock1.ApplicationIdentity = "985321";//must be 6 digit number
            try
            {
                //tLock1.GetSerialNumber();
                txtSerial.Text = tLock1.GetSerialNumber();
                bool reg = tLock1.CheckRegistration();
                switch (reg)
                {
                    case true:
                        txtRegisterStatus.Text = "REGISTERED";
                        break;
                    case false:
                        txtRegisterStatus.Text = "NOT REGISTERED";
                        break;
                }
            }
            catch
            {
                tLock1.Reset();
            }
        }

        private void frmRegisterPayQuick_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txtRegisterStatus.Text == "NOT REGISTERED")
            {
                MessageBox.Show("PayQuick NOT REGISTERED, you have been blocked from further use.");
                Application.Exit();
            }
        }
    }
}
