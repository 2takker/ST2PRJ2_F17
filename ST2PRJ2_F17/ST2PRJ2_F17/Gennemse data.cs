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
    public partial class gennemse_data : Form
    {
        private Gennemse_data_controller GennemseController;
        private List<DTO_Datasæt> datasætListe;
        private Hjemmeskærm frm_;

        public gennemse_data(string brugerId, Hjemmeskærm frm)
        {
            InitializeComponent();

            frm_ = frm;

            GennemseController = new Gennemse_data_controller(brugerId);

        }

        private void indlæsCPRKnap_Click(object sender, EventArgs e)
        {

            string cpr = CPRTextBox.Text;
            datasætListBox.Items.Clear();

            if (GennemseController.validerCPR(cpr) == false && cpr != "1234567890")
            {
                MessageBox.Show("CPR - nummeret er ugyldigt");
                CPRTextBox.Clear();
            }
            else if (GennemseController.indlæsCPR(cpr) == true)
            {
                if (cpr == "1234567890")
                {
                    MessageBox.Show("Advarsel: Dette er CPR-nummer er gældende for alle anonyme patienter");
                }
                    datasætListe = GennemseController.visPatientData(cpr);

                    fornavnTextBox.Text = datasætListe[0].Pd_.Fornavn_;
                    efternavnTextBox.Text = datasætListe[0].Pd_.Efternavn_;

                    foreach (DTO_Datasæt ds in datasætListe)
                    {
                        datasætListBox.Items.Add(Convert.ToString(ds.Dato_));
                    }                
            }
            else
            {
                CPRTextBox.Clear();
                fornavnTextBox.Clear();
                efternavnTextBox.Clear();
                MessageBox.Show("Der findes ingen datasæt til pågældende patient");                
            }
            

            

            


        }

        private void analyserDataKnap_Click(object sender, EventArgs e)
        {
            if (GennemseController.analyserValgtDatasæt(datasætListBox.SelectedIndex) == true)
            {
                vis_måling visMåling = new vis_måling(this, GennemseController);
                visMåling.åbenVisMålingVindue();
            }
        }


        public void åbenGennemseDataVindue()
        {
            frm_.låsHjemmeskærm(true);
            Show();
            CPRTextBox.Focus();
        }

        public void lukGennemseDataVindue()
        {
            frm_.låsHjemmeskærm(false);
            Close();
        }

        private void datasætListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            analyserDataKnap.Enabled = true;
        }

        private void gennemse_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_.låsHjemmeskærm(false);
        }
    }
}
