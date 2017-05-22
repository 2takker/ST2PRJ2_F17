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
    public partial class vis_måling : Form
    {
        private gennemse_data frm;
        private Gennemse_data_controller GennemseController;
        private double x;
        private List<double> ipliste;
        private double ip;
        private int count;
        private DTO_Datasæt datasæt_;
        private double dataCountCorr;

        public vis_måling(gennemse_data frm, Gennemse_data_controller GennemseController)
        {
            InitializeComponent();

            Cursor = Cursors.WaitCursor;

            this.frm = frm;
            this.GennemseController = GennemseController;
            ipliste = new List<double>();
            count = 0;
            ipTilbageKnap.Enabled = false;
            analyseretData.Annotations["IP"].Visible = false;

            datasæt_ = GennemseController.hentAnalyseretDatasæt();

            CPRTextBox.Text = datasæt_.Pd_.CPRNummer_;
            fornavnTextBox.Text = datasæt_.Pd_.Fornavn_;
            efternavnTextBox.Text = datasæt_.Pd_.Efternavn_;

            gammelkommentar();

            dataCountCorr = ((datasæt_.Data_.Count) - (datasæt_.Data_.Count % datasæt_.SampleRateHz_)) / datasæt_.SampleRateHz_;

            skrivTilGraf(0, true);
            ipTekstBox.Text = "" + datasæt_.Ip_.Count;

            Cursor = Cursors.Default;
        }

        private void gammelkommentar()
        {
            Cursor = Cursors.WaitCursor;
            string kommentar = "Måltagers kommentar: \r\n" + datasæt_.printMåltagerKommentar() + "\r\n"
                   + "Tidligere kommentarer fra ansvarstager(e): \r\n" + datasæt_.printAnsvarstagerKommentar();
            gammelKommentartextBox.Text = kommentar;
            Cursor = Cursors.Default;
        }

        private bool checkForIP()
        {
            if (datasæt_.Ip_.Count == 0)
            {
                ipFremKnap.Enabled = false;
                labelNoIP.Visible = true;
                GemAnalyseretDataKnap.Enabled = false;

                return false;
            }
            else
            {
                return true;
            }
        }


        private void skrivTilGraf(double start, bool nextIp)
        {
            Cursor = Cursors.WaitCursor;

            if (checkForIP() && nextIp)
            {
                double preCorrX = (datasæt_.Ip_[count] / datasæt_.SampleRateHz_);
                double corr = preCorrX % 10;
                analyseretData.Annotations["IP"].X = preCorrX + 1;
                analyseretData.Annotations["IP"].Visible = true;
                x = preCorrX - corr;
                start = x;                
            }
            else
            {
                x = start;
            }

            analyseretData.Series["EKG"].Points.Clear();

            for (double i = (x * datasæt_.SampleRateHz_);
                i < (start + 10) * datasæt_.SampleRateHz_ && i < datasæt_.Data_.Count; i++)
            {
                analyseretData.Series["EKG"].Points.AddXY(x + (1 / datasæt_.SampleRateHz_), datasæt_.Data_[Convert.ToInt32(i)]);
                x += (1 / datasæt_.SampleRateHz_);
                x = Math.Round(x, 4);
            }

            if (x <= 10)
            {
                tiSekTilbageKnap.Enabled = false;
            }

            if (x >= dataCountCorr)
            {
                tiSekFremKnap.Enabled = false;
            }

            if (datasæt_.Ip_.Count != 0)
            {
                if (count == datasæt_.Ip_.Count - 1)
                {
                    ipFremKnap.Enabled = false;                    
                }
                //if((x + 10) >= (datasæt_.Ip_[datasæt_.Ip_.Count - 1]) / datasæt_.SampleRateHz_)
                //{
                //    ipFremKnap.Enabled = false;
                //    count = datasæt_.Ip_.Count - 1;
                //}

                if (count == 0)
                {
                    ipTilbageKnap.Enabled = false;
                }
            }


            Cursor = Cursors.Default;
        }

        private void tiSekTilbageKnap_Click(object sender, EventArgs e)
        {
            analyseretData.Annotations["IP"].Visible = false;
            if (x != 0)
            {
                x = x - 20;
                skrivTilGraf(x, false);

                tiSekFremKnap.Enabled = true;
            }
        }

        private void tiSekFremKnap_Click(object sender, EventArgs e)
        {
            analyseretData.Annotations["IP"].Visible = false;
            skrivTilGraf(x, false);

            tiSekTilbageKnap.Enabled = true;
        }

        private void ipTilbageKnap_Click(object sender, EventArgs e)
        {
            count--;
            ip = (datasæt_.Ip_[count] / datasæt_.SampleRateHz_);
            skrivTilGraf(ip, true);

            ipFremKnap.Enabled = true;
        }

        private void ipFremKnap_Click(object sender, EventArgs e)
        {
            count++;
            ip = (datasæt_.Ip_[count] / datasæt_.SampleRateHz_);
            skrivTilGraf(ip, true);

            ipTilbageKnap.Enabled = true;
        }

        private void gemKommentarKnap_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            datasæt_.AnsvarstagerKommentar_.Add(DateTime.Now + "\r\n" + kommentarTextBox.Text);
            if (GennemseController.gemKommentar(datasæt_) == true)
            {
                kommentarTextBox.Clear();
                gammelkommentar();
            }
            Cursor = Cursors.Default;
        }

        public void åbenVisMålingVindue()
        {
            Show();
        }
        public void lukVisMålingVindue()
        {
            Close();
        }


        private void GemAnalyseretDataKnap_Click(object sender, EventArgs e)
        {
            if (GennemseController.gemAnalyseretData(datasæt_) == true)
            {
                MessageBox.Show("Datasæt gemt");
            }
            else
            {
                MessageBox.Show("Datasæt ikke gemt");
            }
        }
    }
}
