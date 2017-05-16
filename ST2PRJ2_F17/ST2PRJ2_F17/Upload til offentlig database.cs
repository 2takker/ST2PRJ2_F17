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

        public upload_til_offentlig_database()
        {
            InitializeComponent();
            UploadController = new Upload_controller();
            datasætListe = new List<DTO_Datasæt>();
            anonym = false;
        }

        private void IndlæsCPRKnap_Click(object sender, EventArgs e)
        {
            string cpr;
            cpr = CPRTextBox.Text;

            datasætListe = UploadController.visSøgning(cpr);

            if (datasætListe.Count != 0)
            {
                foreach (DTO_Datasæt ds in datasætListe)
                {
                    valgAfDatasætListBox.Items.Add(ds.Dato_);
                }
            }
            else
            {
                valgAfDatasætListBox.Text = "Der findes ingen datasæt til pågældende patient";
            }
        }

        private void uploadKnap_Click(object sender, EventArgs e)
        {
            if(UploadController.indlæsValgtDatasæt(valgAfDatasætListBox.SelectedIndex, anonym))
            {
                MessageBox.Show("Datasæt uploaded");
            }

        }

        public void åbenUploadVindue()
        {
            Show();
        }

        public void lukUploadVindue()
        {
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
    }
}
