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
using System.IO;

namespace Præsentationslag
{
    public partial class preview : Form
    {
        private Preview_controller PreviewController;
        private CPR_nummer cprvindue;
        double x;
        List<double> dataListe_;

        public preview()
        {
            InitializeComponent();
            PreviewController = new Preview_controller();
            dataListe_ = new List<double>();
            x = 0;

            tiSekFremKnap.Enabled = false;
            tiSekTilbageKnap.Enabled = false;
        }

        private void genKnap_Click(object sender, EventArgs e)
        {
            cprvindue = new CPR_nummer();
            cprvindue.åbenCPRVindue();
        }

        private void kasserKnap_Click(object sender, EventArgs e)
        {
            kasserData();
        }

        private void kasserData()
        {
            DialogResult dr;
            dr = MessageBox.Show("Vil du kassere måling?", "Kassér måling", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                lukPreviewVindue();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void tiSekTilbageKnap_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                x = x - 20;
                skrivTilGraf(x);
                if (x <= 10)
                {
                    tiSekTilbageKnap.Enabled = false;
                }
                tiSekFremKnap.Enabled = true;
            }
        }

        private void tiSekFremKnap_Click(object sender, EventArgs e)
        {
            skrivTilGraf(x);            
            if (x >= (dataListe_.Count / 500))
            {
                tiSekFremKnap.Enabled = false;
            }
            tiSekTilbageKnap.Enabled = true;
        }

        private void gemKommentar_Click(object sender, EventArgs e)
        {
            if (PreviewController.gemKommentar(kommentarTextBox.Text) == true)
            {
                kommentarTextBox.Clear();
                MessageBox.Show("Kommentar gemt");
            }
            else
            {
                MessageBox.Show("Kommentar ikke gemt");
            }

        }

        private void importerFilKnap_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            dataListe_ = PreviewController.importerDatafil(myStream);
                            skrivTilGraf(0);
                            tiSekFremKnap.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunne ikke læse filen fra disken: " + ex.Message);
                }
            }
            
        }

        private void skrivTilGraf(double start)
        {
            x = start;
            previewData.Series["EKG"].Points.Clear();

            for (double i = (x * 500); i <= (start + 10) * 500; i++)
            {
                previewData.Series["EKG"].Points.AddXY(x + 0.002, dataListe_[Convert.ToInt32(i)]);
                x += 0.002;
                x = Math.Round(x, 3);
            }
            x -= 0.002;
            x = Math.Round(x, 3);
        }


        public void åbenPreviewVindue()
        {
            Show();
        }
        public void lukPreviewVindue()
        {
            Close();
        }
    }

}

