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
   public partial class log_ind : Form
   {
      private Logik loginController;

      public log_ind()
      {
         InitializeComponent();

         loginController = new Logik();
      }

      private void LogIndKnap_Click(object sender, EventArgs e)
      {
         DTO_sundhedsPersonale sp1 = new DTO_sundhedsPersonale(brugernavnTextBox.Text, adgangskodeTextBox.Text);

         loginController.login(sp1);

      }

      public void åbenLoginVindue(log_ind login)
      {
         login.Show();
         login.BringToFront();
      }

      public void lukLoginVindue(log_ind login)
      {
         login.Close();
      }

      public void ugyldigLogin()
      {
         MessageBox.Show("Ugyldigt brugernavn eller adgangskode");
      }
   }
}
