using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDVIProcessor
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(25);
            if (progressBar1.Value == 0)
            {
                label2.Text = "Importing NiR/RGB Image.. (1/5)";
       
            }
            if (progressBar1.Value == 25)
            {
                label2.Text = "Splitting Channels... (3/5)";
            } 
            if (progressBar1.Value == 50)
            {
                label2.Text = "Running through NDVI Formula... (4/5)";
            }
            if (progressBar1.Value == 75)
            {
                label2.Text = "Applying Color Map... (5/5)";
            }
            if (progressBar1.Value == 100)
            {
                label2.Text = "Exporting...";
                this.Close();
            }

        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = true;
        }
    }
}
