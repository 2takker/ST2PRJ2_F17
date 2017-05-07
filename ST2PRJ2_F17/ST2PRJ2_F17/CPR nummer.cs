using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Logik;

namespace Præsentationslag
{
    public partial class CPR_nummer : Form
    {
        private Preview_controller PreviewController;
        private opret_ny_patient OpretPatientVindue;
        private Opret_ny_patient_controller OpretPatientController;
        public CPR_nummer()
        {
            InitializeComponent();
            PreviewController = new Preview_controller();
            OpretPatientController = new Opret_ny_patient_controller();
        }

        private void gemKnap_Click(object sender, EventArgs e)
        {
            string cpr = CPRTextBox.Text;

            if (OpretPatientController.validerCPR(cpr) == false)
            {
                MessageBox.Show("CPR-nummeret er ugyldigt");
                CPRTextBox.Clear();
            }
            else
            {
                if (PreviewController.indlæsCPR(cpr) == true)
                {

                    MessageBox.Show("Datasæt gemt");
                    lukCPRVindue();
                }
                else
                {
                    OpretPatientVindue = new opret_ny_patient();
                    OpretPatientVindue.åbenOpretNyPatientVindue();
                }

            }
        }

        private void fortrydKnap_Click(object sender, EventArgs e)
        {
            lukCPRVindue();
        }

        public void åbenCPRVindue()
        {
            Show();
        }

        public void lukCPRVindue()
        {
            Close();
        }
    }
}
