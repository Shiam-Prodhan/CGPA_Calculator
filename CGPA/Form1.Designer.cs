namespace CGPA
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.CGPAButton = new System.Windows.Forms.Button();
            this.GPAButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panelbody = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.Helpbutton);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.CGPAButton);
            this.panel1.Controls.Add(this.GPAButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 561);
            this.panel1.TabIndex = 0;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(0, 525);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(188, 36);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // CGPAButton
            // 
            this.CGPAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.CGPAButton.FlatAppearance.BorderSize = 0;
            this.CGPAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CGPAButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGPAButton.Location = new System.Drawing.Point(0, 226);
            this.CGPAButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CGPAButton.Name = "CGPAButton";
            this.CGPAButton.Size = new System.Drawing.Size(188, 58);
            this.CGPAButton.TabIndex = 1;
            this.CGPAButton.Text = "Calculate CGPA";
            this.CGPAButton.UseVisualStyleBackColor = false;
            this.CGPAButton.Click += new System.EventHandler(this.CGPAButton_Click);
            // 
            // GPAButton
            // 
            this.GPAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.GPAButton.FlatAppearance.BorderSize = 0;
            this.GPAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPAButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPAButton.Location = new System.Drawing.Point(0, 162);
            this.GPAButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GPAButton.Name = "GPAButton";
            this.GPAButton.Size = new System.Drawing.Size(188, 58);
            this.GPAButton.TabIndex = 1;
            this.GPAButton.Text = "Calculate GPA";
            this.GPAButton.UseVisualStyleBackColor = false;
            this.GPAButton.Click += new System.EventHandler(this.GPAButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 137);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panelbody
            // 
            this.Panelbody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Panelbody.Controls.Add(this.label14);
            this.Panelbody.Controls.Add(this.pictureBox2);
            this.Panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelbody.Location = new System.Drawing.Point(188, 0);
            this.Panelbody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panelbody.Name = "Panelbody";
            this.Panelbody.Size = new System.Drawing.Size(596, 561);
            this.Panelbody.TabIndex = 1;
            this.Panelbody.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(465, 541);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "© M r . P r o d h a n";
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.Helpbutton.FlatAppearance.BorderSize = 0;
            this.Helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helpbutton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.Location = new System.Drawing.Point(0, 290);
            this.Helpbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(188, 50);
            this.Helpbutton.TabIndex = 1;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Panelbody);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA & CGPA Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panelbody.ResumeLayout(false);
            this.Panelbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button CGPAButton;
        private System.Windows.Forms.Button GPAButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Panelbody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Helpbutton;
    }
}

