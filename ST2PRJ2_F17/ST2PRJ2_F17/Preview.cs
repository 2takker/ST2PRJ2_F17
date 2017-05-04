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
   public partial class preview : Form
   {
      private Preview_controller PreviewController;
      private CPR_nummer cprvindue;
      
      public preview()
      {
         InitializeComponent();
         PreviewController = new Preview_controller();
         
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
         PreviewController.10sekTilbage();
      }

      private void tiSekFremKnap_Click(object sender, EventArgs e)
      {
         PreviewController.10sekFrem();
      }

      private void gemKommentar_Click(object sender, EventArgs e)
      {
         
      }

      public void lukPreviewVindue()
      {
         Close();
      }

      private void importerFilKnap_Click(object sender, EventArgs e)
      {
         PreviewController.importerDatafil();
      }

      public void åbenPreviewVindue()
      {
         Show();
      }
      
   }
}
