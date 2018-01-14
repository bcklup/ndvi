namespace NDVIProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picNir = new System.Windows.Forms.PictureBox();
            this.picRgb = new System.Windows.Forms.PictureBox();
            this.lblNir = new System.Windows.Forms.Label();
            this.lblRgb = new System.Windows.Forms.Label();
            this.btnLoadNir = new System.Windows.Forms.Button();
            this.btnLoadRgb = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRgb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.PowderBlue;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 52);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1071, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NDVI Toolkit -";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(34, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 556);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Controls.Add(this.picOut);
            this.groupBox2.Location = new System.Drawing.Point(20, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NDVIProcessor.Properties.Resources._try;
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 263);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(519, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "NDVI Data/Operation Log";
            // 
            // txtLog
            // 
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLog.Location = new System.Drawing.Point(522, 46);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(246, 241);
            this.txtLog.TabIndex = 13;
            // 
            // picOut
            // 
            this.picOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOut.Location = new System.Drawing.Point(151, 24);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(351, 263);
            this.picOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOut.TabIndex = 12;
            this.picOut.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picNir);
            this.groupBox1.Controls.Add(this.picRgb);
            this.groupBox1.Controls.Add(this.lblNir);
            this.groupBox1.Controls.Add(this.lblRgb);
            this.groupBox1.Controls.Add(this.btnLoadNir);
            this.groupBox1.Controls.Add(this.btnLoadRgb);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // picNir
            // 
            this.picNir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNir.Location = new System.Drawing.Point(528, 24);
            this.picNir.Name = "picNir";
            this.picNir.Size = new System.Drawing.Size(206, 143);
            this.picNir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNir.TabIndex = 12;
            this.picNir.TabStop = false;
            // 
            // picRgb
            // 
            this.picRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRgb.Location = new System.Drawing.Point(307, 24);
            this.picRgb.Name = "picRgb";
            this.picRgb.Size = new System.Drawing.Size(206, 143);
            this.picRgb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRgb.TabIndex = 11;
            this.picRgb.TabStop = false;
            // 
            // lblNir
            // 
            this.lblNir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNir.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNir.Location = new System.Drawing.Point(66, 132);
            this.lblNir.Name = "lblNir";
            this.lblNir.Size = new System.Drawing.Size(166, 15);
            this.lblNir.TabIndex = 10;
            this.lblNir.Text = "NiR Input is missing or invalid.";
            this.lblNir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRgb
            // 
            this.lblRgb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgb.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRgb.Location = new System.Drawing.Point(64, 72);
            this.lblRgb.Name = "lblRgb";
            this.lblRgb.Size = new System.Drawing.Size(169, 15);
            this.lblRgb.TabIndex = 9;
            this.lblRgb.Text = "RGB Input is missing or invalid.";
            this.lblRgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadNir
            // 
            this.btnLoadNir.BackColor = System.Drawing.Color.White;
            this.btnLoadNir.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnLoadNir.FlatAppearance.BorderSize = 2;
            this.btnLoadNir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadNir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadNir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLoadNir.Location = new System.Drawing.Point(67, 99);
            this.btnLoadNir.Name = "btnLoadNir";
            this.btnLoadNir.Size = new System.Drawing.Size(151, 30);
            this.btnLoadNir.TabIndex = 6;
            this.btnLoadNir.Text = "OPEN NiR FILE";
            this.btnLoadNir.UseVisualStyleBackColor = false;
            this.btnLoadNir.Click += new System.EventHandler(this.btnLoadNir_Click);
            // 
            // btnLoadRgb
            // 
            this.btnLoadRgb.BackColor = System.Drawing.Color.White;
            this.btnLoadRgb.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnLoadRgb.FlatAppearance.BorderSize = 2;
            this.btnLoadRgb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRgb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRgb.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLoadRgb.Location = new System.Drawing.Point(69, 39);
            this.btnLoadRgb.Name = "btnLoadRgb";
            this.btnLoadRgb.Size = new System.Drawing.Size(151, 30);
            this.btnLoadRgb.TabIndex = 5;
            this.btnLoadRgb.Text = "OPEN RGB FILE";
            this.btnLoadRgb.UseVisualStyleBackColor = false;
            this.btnLoadRgb.Click += new System.EventHandler(this.btnLoadRgb_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(884, 97);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(192, 45);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "RUN SCRIPT";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(884, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG |*.png|JPEG |*.jpg";
            this.openFileDialog1.Title = "Choose Input files";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG |*.png|JPEG |*.jpg";
            this.saveFileDialog1.Title = "Save Output as:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(884, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "GENERATE GUIDANCE MAP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(881, 222);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(195, 316);
            this.label5.TabIndex = 6;
            this.label5.Text = "GUIDELINES:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NDVIProcessor.Properties.Resources.ndvibg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NDVI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRgb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNir;
        private System.Windows.Forms.Label lblRgb;
        private System.Windows.Forms.Button btnLoadNir;
        private System.Windows.Forms.Button btnLoadRgb;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.PictureBox picNir;
        private System.Windows.Forms.PictureBox picRgb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

