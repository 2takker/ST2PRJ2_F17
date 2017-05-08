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
        private Hjemmeskærm frm;

        public log_ind(Hjemmeskærm frm)
        {
            InitializeComponent();

            this.frm = frm;

            loginController = new Log_ind_controller();
        }

        private void LogIndKnap_Click(object sender, EventArgs e)
        {
            logInd();
        }

        public void åbenLoginVindue()
        {
            Show();
        }

        private void lukLoginVindue()
        {
            brugernavnTextBox.Clear();
            adgangskodeTextBox.Clear();
            Hide();
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

        private void adgangskodeTextBox_Enter(object sender, EventArgs e)
        {
            logInd();
        }

       private void logInd()
        {
            DTO_Sundhedspersonale sp1 = new DTO_Sundhedspersonale(brugernavnTextBox.Text, adgangskodeTextBox.Text);
            string brugerID = loginController.login(sp1);

            if (brugerID != null)
            {
                loggedIn_ = true;
                frm.brugerID_ = brugerID;
                frm.låsHjemmeskærm(false);
                lukLoginVindue();
            }
            else
            {
                ugyldigtLogin();
            }
        }

        private void adgangskodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Keys.Enter))
            {
                logInd();
            }
        }
    }
}
