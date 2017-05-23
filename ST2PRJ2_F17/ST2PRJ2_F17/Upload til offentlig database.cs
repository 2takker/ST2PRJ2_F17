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
    public partial class upload_til_offentlig_database : Form
    {
        private Upload_controller UploadController;
        private List<DTO_Datasæt> datasætListe;
        private bool anonym;
        private Hjemmeskærm frm_;

        public upload_til_offentlig_database(Hjemmeskærm frm)
        {
            InitializeComponent();

            frm_ = frm;

            UploadController = new Upload_controller();
            datasætListe = new List<DTO_Datasæt>();
            anonym = false;
        }

        private void IndlæsCPRKnap_Click(object sender, EventArgs e)
        {
            string cpr;
            cpr = CPRTextBox.Text;

            valgAfDatasætListBox.Items.Clear();

            datasætListe = UploadController.visSøgning(cpr);

            if (datasætListe != null && datasætListe.Count != 0)
            {
                fornavnTextBox.Text = datasætListe[0].Pd_.Fornavn_;
                efternavnTextBox.Text = datasætListe[0].Pd_.Efternavn_;

                if (datasætListe[0].EkgId_ != 0)
                {
                    foreach (DTO_Datasæt ds in datasætListe)
                    {
                        valgAfDatasætListBox.Items.Add(Convert.ToString(ds.Dato_));
                    }
                }
                else
                {
                    MessageBox.Show("Der findes ingen datasæt til pågældende patient");
                }
            }
            else
            {
                MessageBox.Show("Patient findes ikke");
            }
            
            uploadKnap.Enabled = false;
        }

        private void uploadKnap_Click(object sender, EventArgs e)
        {
            if (valgAfDatasætListBox.SelectedIndex >= 0)
            {
                if (UploadController.indlæsValgtDatasæt(valgAfDatasætListBox.SelectedIndex, anonym))
                {
                    MessageBox.Show("Datasæt uploaded");
                }
                else
                {
                    MessageBox.Show("Datasæt blev ikke uploaded");
                }
            }

        }

        public void åbenUploadVindue()
        {
            frm_.låsHjemmeskærm(true);
            Show();
        }

        public void lukUploadVindue()
        {
            frm_.låsHjemmeskærm(false);
            Close();
        }

        private void UdenPatientDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UdenPatientDataCheckBox.Checked)
            {
                anonym = true;
            }
            else
            {
                anonym = false;
            }
        }

        private void CPRTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IndlæsCPRKnap.PerformClick();
            }
        }

        private void upload_til_offentlig_database_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_.låsHjemmeskærm(false);
        }

        private void valgAfDatasætListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uploadKnap.Enabled = true;
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
