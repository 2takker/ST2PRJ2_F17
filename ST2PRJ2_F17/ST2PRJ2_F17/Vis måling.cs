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
   public partial class vis_måling : Form
   {
      private gennemse_data frm;
      private Gennemse_data_controller GennemseController;
      private double x;

      public vis_måling(gennemse_data frm, Gennemse_data_controller GennemseController)
      {
         InitializeComponent();
         this.frm = frm;
         this.GennemseController = GennemseController;
      }

      private void skrivTilGraf(double start)
      {
         x = start;
         analyseretData.Series["EKG"].Points.Clear();

         for (double i = (x * 500); i <= (start + 10) * 500; i++)
         {
            analyseretData.Series["EKG"].Points.AddXY(x + 0.002, dataListe_[Convert.ToInt32(i)]);
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
         if (x >= (dataListe_.Count / 500))
         {
            tiSekFremKnap.Enabled = false;
         }
         tiSekTilbageKnap.Enabled = true;
      }

      private void ipTilbageKnap_Click(object sender, EventArgs e)
      {

      }

      private void ipFremKnap_Click(object sender, EventArgs e)
      {

      }

      private void gemKommentarKnap_Click(object sender, EventArgs e)
      {
         if (gennemseDataController.gemKommentar(kommentarTextBox.Text) == true)
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
