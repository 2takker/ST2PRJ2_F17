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
   public partial class opret_ny_patient : Form
   {
      private Opret_ny_patient_controller OpretPatientController;
      public opret_ny_patient()
      {         
            InitializeComponent();

            OpretPatientController = new Opret_ny_patient_controller();         
      }

      private void gemKnap_Click(object sender, EventArgs e)
      {
         DTO_PatientData pd = new DTO_PatientData(CPRTextBox.Text, fornavnTextBox.Text, efternavnTextBox.Text);

         if (OpretPatientController.validerCPR(pd.CPRNummer_)==false)
         {
            MessageBox.Show("CPR-nummeret er ugyldigt");
            CPRTextBox.Clear();
         }
         else
         {
            if (OpretPatientController.gemPatientData(pd) == true)
            {
               
               MessageBox.Show("Patient findes allerede");
               lukOpretNyPatientVindue();
            }
            else
            {
               MessageBox.Show("Data er gemt");
               lukOpretNyPatientVindue();
            }
            
         }
         
      }

      private void fortrydKnap_Click(object sender, EventArgs e)
      {
         lukOpretNyPatientVindue();
      }

      private void lukOpretNyPatientVindue()
      {
         this.Close();
      }

      public void åbenOpretNyPatientVindue()
      {
         this.Show();
      }
   }
}
