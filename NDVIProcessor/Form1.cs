using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDVIProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "NOTES:\n\n- Always maintain the accuracy of 2 input images before proceeding, this will assure optimal results.\n\n- If there is no output from the operation, check input images for corruption and unsupported formats.";
        }
        public string nirdir = "";
        public string rgbdir = "";
        public string outdir = "";
        public int cmap;

        int mouseX = 0, mouseY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkSlateGray;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rgbdir = "";
            outdir = "";
            nirdir = "";
            IsVarsSet();
            picNir.Image = null;
            picRgb.Image = null;
            picOut.Image = null;
            txtLog.Clear();
        }
        private bool IsVarsSet()
        {
            if (rgbdir == "" || nirdir=="")
            {
                lblRgb.Text = "RGB Input is ready.";
                lblRgb.ForeColor = Color.ForestGreen;
                lblNir.Text = "NiR Input is ready.";
                lblNir.ForeColor = Color.ForestGreen;

                if (rgbdir == "") {
                    lblRgb.Text = "RGB Input is missing or invalid.";
                    lblRgb.ForeColor = Color.Firebrick;
                }
                if (nirdir == "")
                {
                    lblNir.Text = "NiR Input is missing or invalid.";
                    lblNir.ForeColor = Color.Firebrick;
                }
                return false;
            }
            else
            {
                lblRgb.Text = "RGB Input is ready.";
                lblRgb.ForeColor = Color.ForestGreen;
                lblNir.Text = "NiR Input is ready.";
                lblNir.ForeColor = Color.ForestGreen;
                return true;
            }
        }

        private void btnLoadRgb_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                rgbdir = openFileDialog1.FileName;
                picRgb.Image = Image.FromFile(rgbdir);
                IsVarsSet();
            }
        }

        private void btnLoadNir_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                nirdir = openFileDialog1.FileName;
                picNir.Image = Image.FromFile(nirdir);
                IsVarsSet();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (IsVarsSet()) {
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ProcessStartInfo pythonInfo = new ProcessStartInfo();
                    Process python;
                    pythonInfo.FileName = @"C:\Program Files (x86)\Python36-32\python.exe";
                    //pythonInfo.Arguments = string.Format("{0} -n {1} -r {2} -o {3}", AppDomain.CurrentDomain.BaseDirectory + "ndvi.py", nirdir, rgbdir, saveFileDialog1.FileName);
                    pythonInfo.Arguments = "\""+AppDomain.CurrentDomain.BaseDirectory+"ndvi.py"+"\""+" -n \"" + nirdir + "\" -r \"" + rgbdir + "\" -o \"" + saveFileDialog1.FileName+"\" -c \""+cmap+"\"";
                    //MessageBox.Show(pythonInfo.Arguments);
                    //MessageBox.Show(pythonInfo.Arguments);
                    pythonInfo.CreateNoWindow = false;
                    pythonInfo.UseShellExecute = false;
                    pythonInfo.RedirectStandardOutput = true;
                    Loading frm = new Loading();
                    frm.ShowDialog ();

                    python = Process.Start(pythonInfo);

                    string log = python.StandardOutput.ReadToEnd();
                    python.WaitForExit();
                    txtLog.Text = log;
                    python.Close();
                    MessageBox.Show(this, "Operation Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picOut.Image = Image.FromFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Select RGB and NiR Image to process.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void picRgb_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmap = comboBox1.SelectedIndex;
        }
    }
}
