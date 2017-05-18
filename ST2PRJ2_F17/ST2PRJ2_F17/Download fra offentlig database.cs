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
    public partial class Download_fra_offentlig_database : Form
    {
        private Download_controller DownloadController;
        private List<DTO_Datasæt> datasætListe;
        private Hjemmeskærm frm_;

      public Download_fra_offentlig_database(Hjemmeskærm frm)
        {
            InitializeComponent();

            frm_ = frm;

            DownloadController = new Download_controller();
            datasætListe = new List<DTO_Datasæt>();
        }

        private void søgKnap_Click(object sender, EventArgs e)
        {
            string søgeord;
            søgeord = SøgeTextBox.Text;


            datasætListe = DownloadController.visSøgning(søgeord);

            if (datasætListe.Count != 0)
            {
                foreach (DTO_Datasæt ds in datasætListe)
                {
                    SøgeresultaterListBox.Items.Add(ds.SøgeResultat_);                    
                }
            }
            else
            {
                MessageBox.Show("Der findes ingen datasæt til pågældende søgeord");
            }
        }


        private void downloadKnap_Click(object sender, EventArgs e)
        {
            if (DownloadController.indlæsValgtDatasæt(SøgeresultaterListBox.SelectedIndex))
            {
                MessageBox.Show("Datasæt downloaded");                
            }
            else
            {
                MessageBox.Show("Datasæt blev ikke downloaded");
            }
        }

        public void åbenDownloadVindue()
        {
            frm_.låsHjemmeskærm(true);
            Show();
        }
        public void lukDownloadVindue()
        {
            frm_.låsHjemmeskærm(false);
            Close();
        }

        private void Download_fra_offentlig_database_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_.låsHjemmeskærm(false);
        }

        private void SøgeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                søgKnap.PerformClick();
            }
        }

        private void SøgeresultaterListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 60;
        }

        private void SøgeresultaterListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(SøgeresultaterListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
    }
}


