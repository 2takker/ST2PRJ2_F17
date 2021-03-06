﻿using System;
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
        private double x;
        private List<double> dataListe_;
        private List<string> kommListe_;
        private Hjemmeskærm frm_;


        public preview(string brugerID, Hjemmeskærm frm)
        {
            InitializeComponent();

            frm_ = frm;

            PreviewController = new Preview_controller();
            dataListe_ = new List<double>();
            kommListe_ = new List<string>();

            x = 0;

            PreviewController.indlæsBrugerId(brugerID);

            tiSekFremKnap.Enabled = false;
            tiSekTilbageKnap.Enabled = false;
            genKnap.Enabled = false;
            kasserKnap.Enabled = false;
            gemKommentar.Enabled = false;
        }

        private void genKnap_Click(object sender, EventArgs e)
        {
            cprvindue = new CPR_nummer(this, PreviewController);
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
                
                tiSekFremKnap.Enabled = true;
            }
        }

        private void tiSekFremKnap_Click(object sender, EventArgs e)
        {
            skrivTilGraf(x);
            
            tiSekTilbageKnap.Enabled = true;
        }

        private void gemKommentar_Click(object sender, EventArgs e)
        {
            if (PreviewController.gemKommentar(DateTime.Now + "\r\n" + kommentarTextBox.Text) == true)
            {
                kommListe_.Add(DateTime.Now + "\r\n" + kommentarTextBox.Text);
                gammelKommentartextBox.Text = gemteKommentarer();
                kommentarTextBox.Clear();
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

                            if (x < (dataListe_.Count / 500))
                            {
                                tiSekFremKnap.Enabled = true;
                            }
                            
                            importerFilKnap.Enabled = false;
                            genKnap.Enabled = true;
                            kasserKnap.Enabled = true;
                            gemKommentar.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunne ikke læse filen fra disken: " + ex.Message);
                }
            }
            kommentarTextBox.Focus();

        }

        private void skrivTilGraf(double start)
        {
            Cursor = Cursors.WaitCursor;   
            x = start;
            previewData.Series["EKG"].Points.Clear();
            låsknapper(true);


            for (double i = (x * 500); i < (start + 10) * 500; i++)
            {
                previewData.Series["EKG"].Points.AddXY(x + 0.002, dataListe_[Convert.ToInt32(i)]);
                x += 0.002;
                x = Math.Round(x, 3);
            }            

            låsknapper(false);

            if (x <= 10)
            {
                tiSekTilbageKnap.Enabled = false;
            }

            if (x >= (dataListe_.Count / 500) && x != 0)
            {
                tiSekFremKnap.Enabled = false;
            }

            Cursor = Cursors.Default;


            
        }


        public void åbenPreviewVindue()
        {
            frm_.låsHjemmeskærm(true);
            Show();
        }
        public void lukPreviewVindue()
        {
            frm_.låsHjemmeskærm(false);
            Close();
        }

        private string gemteKommentarer()
        {
            string output = "";

            foreach (string e in kommListe_)
            {
                output += "" + e + "\r\n\r\n";
            }

            return output;
        }

        private void preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_.låsHjemmeskærm(false);
        }

        private void låsknapper(bool lås)
        {
            tiSekFremKnap.Enabled = !lås;
            tiSekTilbageKnap.Enabled = !lås;
        }
    }

}

