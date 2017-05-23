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
        private preview frm;

        public CPR_nummer(preview frm, Preview_controller PreviewController)
        {
            InitializeComponent();
            //PreviewController = new Preview_controller();
            OpretPatientController = new Opret_ny_patient_controller();
            this.frm = frm;
            this.PreviewController = PreviewController;
            CPRTextBox.Focus();
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
                switch (PreviewController.indlæsCPR(cpr))
                {
                    case 0:
                        {
                            MessageBox.Show("Datasæt gemt");
                            lukCPRVindue();
                            frm.lukPreviewVindue();
                            break;
                        }
                    case 1:
                        {
                            MessageBox.Show("Datasæt ikke gemt");
                            break;
                        }
                    case 2:
                        {
                            OpretPatientVindue = new opret_ny_patient(null,this);
                            OpretPatientVindue.åbenOpretNyPatientVindue(CPRTextBox.Text);
                            break;
                        }
                }
            }
        }

        private void fortrydKnap_Click(object sender, EventArgs e)
        {
            lukCPRVindue();
        }

        public void åbenCPRVindue()
        {
            frm.Enabled = false;
            Show();
        }

        public void lukCPRVindue()
        {           
            Close();
        }

        private void CPRTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                gemKnap.PerformClick();
            }
        }

        private void CPR_nummer_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Enabled = true;
        }

        private void CPRTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
