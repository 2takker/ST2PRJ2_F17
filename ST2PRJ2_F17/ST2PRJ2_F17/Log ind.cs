using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logik;
using DTO;

namespace Præsentationslag
{
    public partial class log_ind : Form
    {
        private Log_ind_controller loginController;
        private bool loggedIn_;

        public log_ind()
        {
            InitializeComponent();

            loginController = new Log_ind_controller();
        }

        private void LogIndKnap_Click(object sender, EventArgs e)
        {
            DTO_Sundhedspersonale sp1 = new DTO_Sundhedspersonale(brugernavnTextBox.Text, adgangskodeTextBox.Text);
            string brugerID = loginController.login(sp1);

            if (brugerID != null)
            {
                loggedIn_ = true;
                lukLoginVindue();
            }
            else
            {
                ugyldigtLogin();
            }
        }

        public void åbenLoginVindue()
        {
            Application.Run(new log_ind());
        }

        private void lukLoginVindue()
        {
            Close();
        }

        private void ugyldigtLogin()
        {
            adgangskodeTextBox.Clear();
            MessageBox.Show("Ugyldigt brugernavn eller adgangskode");
            adgangskodeTextBox.Focus();
        }

        private void log_ind_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loggedIn_)
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
