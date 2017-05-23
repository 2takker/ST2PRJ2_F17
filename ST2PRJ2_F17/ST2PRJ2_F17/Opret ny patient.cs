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
    public partial class opret_ny_patient : Form
    {
        private Opret_ny_patient_controller OpretPatientController;
        private Hjemmeskærm frm_;
        private CPR_nummer cprFrm_;
        public opret_ny_patient(Hjemmeskærm frm, CPR_nummer cprFrm)
        {
            InitializeComponent();

            frm_ = frm;
            cprFrm_ = cprFrm;

            OpretPatientController = new Opret_ny_patient_controller();
        }

        private void gemKnap_Click(object sender, EventArgs e)
        {
            DTO_PatientData pd = new DTO_PatientData(CPRTextBox.Text, fornavnTextBox.Text, efternavnTextBox.Text);

            if (OpretPatientController.validerCPR(pd.CPRNummer_) == false)
            {
                MessageBox.Show("CPR-nummeret er ugyldigt");
                CPRTextBox.Clear();
            }
            else
            {
                if (OpretPatientController.gemPatientData(pd) == true)
                {

                    MessageBox.Show("Patient findes allerede");
                    lukOpretNyPatientVindue();
                }
                else
                {
                    MessageBox.Show("Patient gemt");
                    lukOpretNyPatientVindue();
                }

            }

        }

        private void fortrydKnap_Click(object sender, EventArgs e)
        {
            lukOpretNyPatientVindue();
        }

        private void lukOpretNyPatientVindue()
        {
            Close();
        }

        public void åbenOpretNyPatientVindue(string cpr)
        {
            CPRTextBox.Focus();
            if (frm_ != null)
            {
                frm_.låsHjemmeskærm(true);
            }
            if (cprFrm_ != null)
            {
                cprFrm_.Enabled = false;
            }
            if (cpr != null)
            {
                CPRTextBox.Text = cpr;
                fornavnTextBox.Focus();
            }

            Show();
        }

        private void opret_ny_patient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm_ != null)
            {
                frm_.låsHjemmeskærm(false);
            }

            if (cprFrm_ != null)
            {
                cprFrm_.Enabled = true;
            }
        }

        private void efternavnTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gemKnap.PerformClick();
            }
        }

        private void CPRTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
