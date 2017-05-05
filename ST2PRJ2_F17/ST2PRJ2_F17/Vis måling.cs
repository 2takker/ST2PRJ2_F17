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
      //private gennemse_data_controller gennemseDataController;
      public vis_måling()
      {
         InitializeComponent();
         //gennemseDataController = new gennemse_data_controller();
      }

      private void tiSekTilbageKnap_Click(object sender, EventArgs e)
      {

      }

      private void tiSekFremKnap_Click(object sender, EventArgs e)
      {

      }

      private void ipTilbageKnap_Click(object sender, EventArgs e)
      {

      }

      private void ipFremKnap_Click(object sender, EventArgs e)
      {

      }

      //private void gemKommentarKnap_Click(object sender, EventArgs e)
      //{
      //   if (gennemseDataController.gemKommentar(kommentarTextBox.Text) == true)
      //   {
      //      MessageBox.Show("Kommentar gemt");
      //   }
      //}

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
