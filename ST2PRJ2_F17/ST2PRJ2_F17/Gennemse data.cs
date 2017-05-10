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
   public partial class gennemse_data : Form
   {
      private Gennemse_data_controller GennemseController;
      private List<DTO_Datasæt> datasætListe;

      public gennemse_data()
      {
         InitializeComponent();
         GennemseController = new Gennemse_data_controller();
      }

      private void indlæsCPRKnap_Click(object sender, EventArgs e)
      {
         string cpr = CPRTextBox.Text;

         if (GennemseController.indlæsCPR(cpr) == true)
         {

            if (GennemseController.visPatientData(cpr) == null)
            {
               datasætListBox.Text = "Der findes ingen datasæt til pågældende patient";
            }
            else
            {
               fornavnTextBox.Text = datasætListe[0].Pd_.Fornavn_;
               efternavnTextBox.Text = datasætListe[0].Pd_.Efternavn_;

               foreach (DTO_Datasæt ds in datasætListe)
               {
                  datasætListBox.Text += Convert.ToString(ds.Dato_);
               }
            }
         }
      }

      private void analyserDataKnap_Click(object sender, EventArgs e)
      {
         if (GennemseController.analyserValgtDatasæt(datasætListBox.SelectedIndex) == true)
         {
            vis_måling visMåling = new vis_måling(this, GennemseController);
            visMåling.åbenVisMålingVindue();
         }


      }


      private void visMålingKnap_Click(object sender, EventArgs e)
      {
         vis_måling visMåling = new vis_måling(this, GennemseController);
         visMåling.åbenVisMålingVindue();
      }

      public void åbenGennemseDataVindue()
      {
         Show();
      }

      public void lukGennemseDataVindue()
      {
         Close();
      }
   }
}
