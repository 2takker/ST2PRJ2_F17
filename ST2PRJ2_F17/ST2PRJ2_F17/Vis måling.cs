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

        public vis_måling(gennemse_data frm, Gennemse_data_controller GennemseController)
        {
            InitializeComponent();
            this.frm = frm;
            this.GennemseController = GennemseController;
            ipliste = new List<double>();
            count = 0;

            datasæt_ = GennemseController.hentAnalyseretDatasæt();  

            skrivTilGraf(0);
        }

        private bool checkForIP()
        {
            if (datasæt_.Ip_.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void skrivTilGraf(double start)
        {
            if (checkForIP())
            {
                x = (datasæt_.Ip_[0] / 500) - 4;
            }
            else
            {
                x = start;
            }
            
            analyseretData.Series["EKG"].Points.Clear();

            for (double i = (x * 500); i <= (start + 10) * 500; i++)
            {
                analyseretData.Series["EKG"].Points.AddXY(x + 0.002, datasæt_.Data_[Convert.ToInt32(i)]);
                x += 0.002;
                x = Math.Round(x, 3);
            }
            x -= 0.002;
            x = Math.Round(x, 3);
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
            if (x >= (datasæt_.Data_.Count / 500))
            {
                tiSekFremKnap.Enabled = false;
            }
            tiSekTilbageKnap.Enabled = true;
        }

        private void ipTilbageKnap_Click(object sender, EventArgs e)
        {
            count--;
            ip = (ipliste[count] / 500) - 4;
            skrivTilGraf(ip);
        }

        private void ipFremKnap_Click(object sender, EventArgs e)
        {
            count++;
            ip = (ipliste[count] / 500) - 4;
            skrivTilGraf(ip);
        }

        private void gemKommentarKnap_Click(object sender, EventArgs e)
        {
            datasæt_.AnsvarstagerKommentar_.Add(kommentarTextBox.Text);
            if (GennemseController.gemKommentar(datasæt_) == true)
            {
                MessageBox.Show("Kommentar gemt");
            }
        }

        public void åbenVisMålingVindue()
        {
            Show();
        }
        public void lukVisMålingVindue()
        {
            Close();
        }
    }
}
