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
      public Download_fra_offentlig_database()
      {
         InitializeComponent();
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
            SøgeresultaterListBox.Text = "Der findes ingen datasæt til pågældende søgeord";
         }
      }


      private void downloadKnap_Click(object sender, EventArgs e)
      {
         if(DownloadController.indlæsValgtDatasæt(SøgeresultaterListBox.SelectedIndex))
            {
                MessageBox.Show("Datasæt downloaded");
                lukDownloadVindue();
            }
      }

      public void åbenDownloadVindue()
      {
         Show();
      }
      public void lukDownloadVindue()
      {
         Close();
      }
   }
}


