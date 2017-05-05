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
      List<string> y;

      public preview()
      {
         InitializeComponent();
         PreviewController = new Preview_controller();
         y = new List<string>();
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
            if (x < 10)
            {
               tiSekTilbageKnap.Enabled = false;
            }
         }
      }

      private void tiSekFremKnap_Click(object sender, EventArgs e)
      {
         skrivTilGraf(x);
         tiSekFremKnap.Enabled = true;
         if (x >= (y.Count / 500))
         {
            tiSekFremKnap.Enabled = false;
         }
      }

      private void gemKommentar_Click(object sender, EventArgs e)
      {
         if (PreviewController.gemKommentar(kommentarTextBox.Text) == true)
         {
            MessageBox.Show("Kommentar gemt");
         }
          
      }

      private void importerFilKnap_Click(object sender, EventArgs e)
      {
         Stream myStream = null;
         OpenFileDialog openFileDialog1 = new OpenFileDialog();

         openFileDialog1.InitialDirectory = "c:\\";
         openFileDialog1.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
         openFileDialog1.FilterIndex = 2;
         openFileDialog1.RestoreDirectory = true;
         List<string> y = new List<string>();

         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            try
            {
               if ((myStream = openFileDialog1.OpenFile()) != null)
               {
                  using (myStream)
                  {
                     y = PreviewController.importerDatafil(myStream);
                  }
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Kunne ikke læse filen fra disken: " + ex.Message);
            }
         }
         skrivTilGraf(0);
      }

      private void skrivTilGraf(double start)
      {
         x = start;
         previewData.Series["Series1"].Points.Clear();

         for (double i = (x * 500); i <= (start + 10) * 500; i++)
         {
            previewData.Series["Series1"].Points.AddXY(x+0.002, Convert.ToDouble(y[(int)i]));
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

