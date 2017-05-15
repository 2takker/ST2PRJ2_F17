using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Præsentationslag
{
    public partial class Hjemmeskærm : Form
    {
        log_ind loginvindue_;

        public string BrugerID_ { get; set; }

        public Hjemmeskærm()
        {
            InitializeComponent();
            låsHjemmeskærm(true);  

            loginvindue_ = new log_ind(this);
            loginvindue_.åbenLoginVindue();
            loginvindue_.TopMost = true;
        }

        public void låsHjemmeskærm(bool lås)
        {
            Enabled = !lås;
         if (!lås)
         {
            LoggetIndSomtextBox.Text = BrugerID_;
         }
      }

        private void opretNyPatientKnap_Click(object sender, EventArgs e)
        {
            opret_ny_patient opretnypatient = new opret_ny_patient();
            opretnypatient.åbenOpretNyPatientVindue();
        }

        private void previewKnap_Click(object sender, EventArgs e)
        {
            preview previewVindue = new preview(BrugerID_);
            previewVindue.åbenPreviewVindue();
        }

        private void GennemseDataKnap_Click(object sender, EventArgs e)
        {
            gennemse_data gennemseData = new gennemse_data(BrugerID_);
            gennemseData.åbenGennemseDataVindue();
        }

        private void UploadKnap_Click(object sender, EventArgs e)
        {
            upload_til_offentlig_database upload = new upload_til_offentlig_database();
            upload.åbenUploadVindue();
        }

        private void downloadKnap_Click(object sender, EventArgs e)
        {
            Download_fra_offentlig_database download = new Download_fra_offentlig_database();
            download.åbenDownloadVindue();
        }

        private void LogUdKnap_Click(object sender, EventArgs e)
        {
            låsHjemmeskærm(true);
            LoggetIndSomtextBox.Clear();
            loginvindue_.åbenLoginVindue();
         
        }
    }
}
