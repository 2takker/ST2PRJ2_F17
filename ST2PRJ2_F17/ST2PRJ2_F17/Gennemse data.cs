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
   public partial class gennemse_data : Form
   {
      public gennemse_data()
      {
         InitializeComponent();
      }

      private void indlæsCPRKnap_Click(object sender, EventArgs e)
      {

      }

      private void analyserDataKnap_Click(object sender, EventArgs e)
      {

      }

      private void visMålingKnap_Click(object sender, EventArgs e)
      {
         vis_måling visMåling = new vis_måling();
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
