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

        public log_ind(bool ini)
        {
            if (ini)
            {
                InitializeComponent();

                loginController = new Log_ind_controller(false);
            }
        }

        private void LogIndKnap_Click(object sender, EventArgs e)
        {
            DTO_Sundhedspersonale sp1 = new DTO_Sundhedspersonale(brugernavnTextBox.Text, adgangskodeTextBox.Text);

            loginController.login(sp1);

        }

        public void åbenLoginVindue(log_ind login)
        {
            login.Show();
            login.BringToFront();
        }

        public void lukLoginVindue(log_ind login)
        {
            login.Close();
        }

        public void ugyldigtLogin()
        {
            MessageBox.Show("Ugyldigt brugernavn eller adgangskode");
        }
    }
}
