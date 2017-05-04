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
   public partial class Download_fra_offentlig_database : Form
   {
      public Download_fra_offentlig_database()
      {
         InitializeComponent();
      }

      private void søgKnap_Click(object sender, EventArgs e)
      {

      }

      private void downloadKnap_Click(object sender, EventArgs e)
      {

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
