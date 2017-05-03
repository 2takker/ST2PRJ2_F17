using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Logik;

namespace Præsentationslag
{
   public partial class CPR_nummer : Form
   {
      private Preview_controller PreviewController;
      private opret_ny_patient OpretPatientVindue;
      public CPR_nummer()
      {
         InitializeComponent();
         PreviewController = new Preview_controller();
         
      }

      private void gemKnap_Click(object sender, EventArgs e)
      {
         DTO_PatientData cpr = new DTO_PatientData(CPRTextBox.Text);

         if (OpretPatientController.validerCPR(cpr.CPRNummer_) == false)
         {
            MessageBox.Show("CPR-nummeret er ugyldigt");
            CPRTextBox.Clear();
         }
         else
         {
            if (PreviewController.indlæsCPR(cpr) == true)
            {

               MessageBox.Show("Datasæt gemt");
               lukCPRVindue();
            }
            else
            {
               OpretPatientVindue = new opret_ny_patient();
               OpretPatientVindue.åbenOpretNyPatientVindue();
            }

         }
      }

      private void fortrydKnap_Click(object sender, EventArgs e)
      {

      }

      public void åbenCPRVindue()
      {
         Show();
      }

      public void lukCPRVindue()
      {
         Close();
      }
   }
}
