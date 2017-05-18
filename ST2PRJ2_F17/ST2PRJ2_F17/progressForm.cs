using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress
{
    public partial class progressForm : Form
    {        
        public progressForm(string title, string textAboveBar, int max)
        {
            InitializeComponent();

            Title_ = title;
            TextAboveBar_ = textAboveBar;
            Maximum_ = max;            
        }

        public int Maximum_
        {
            get { return prgrsBar.Maximum; }
            set
            {
                prgrsBar.Maximum = value;
            }
        }

        public string Title_
        {
            set
            {
                Text = value;
            }
        }
        
        public string TextAboveBar_
        {
            set
            {
                lblProces.Text = value;
            }
        }

        public int CurrentValue_
        {
            get
            {
                return prgrsBar.Value;
            }
        }

        public void increaseProgress(int amount)
        {
            prgrsBar.Increment(amount);
        }

        public void decreaseProgress(int amount)
        {
            prgrsBar.Increment(-amount);
        }

        public void openProgressForm()
        {            
            Show();
        }

        public void closeProgressForm()
        {
            Hide();
            prgrsBar.Value = 0;
        }

        public bool isAtMaX()
        {
            if(CurrentValue_ == Maximum_)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
