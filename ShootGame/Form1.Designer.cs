namespace ShootGame
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.FireBtn = new System.Windows.Forms.Button();
            this.FireAwayBtn = new System.Windows.Forms.Button();
            this.ReStartBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Red;
            this.LoadBtn.Location = new System.Drawing.Point(675, 36);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 62);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.Color.Red;
            this.SpinBtn.Location = new System.Drawing.Point(675, 140);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(75, 53);
            this.SpinBtn.TabIndex = 1;
            this.SpinBtn.Text = "SPIN";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // FireBtn
            // 
            this.FireBtn.BackColor = System.Drawing.Color.Red;
            this.FireBtn.Location = new System.Drawing.Point(675, 231);
            this.FireBtn.Name = "FireBtn";
            this.FireBtn.Size = new System.Drawing.Size(75, 52);
            this.FireBtn.TabIndex = 2;
            this.FireBtn.Text = "FIRE";
            this.FireBtn.UseVisualStyleBackColor = false;
            this.FireBtn.Click += new System.EventHandler(this.FireBtn_Click);
            // 
            // FireAwayBtn
            // 
            this.FireAwayBtn.BackColor = System.Drawing.Color.Red;
            this.FireAwayBtn.Location = new System.Drawing.Point(675, 316);
            this.FireAwayBtn.Name = "FireAwayBtn";
            this.FireAwayBtn.Size = new System.Drawing.Size(75, 54);
            this.FireAwayBtn.TabIndex = 3;
            this.FireAwayBtn.Text = "FIRE AWAY";
            this.FireAwayBtn.UseVisualStyleBackColor = false;
            this.FireAwayBtn.Click += new System.EventHandler(this.FireAwayBtn_Click);
            // 
            // ReStartBtn
            // 
            this.ReStartBtn.BackColor = System.Drawing.Color.Lime;
            this.ReStartBtn.Location = new System.Drawing.Point(388, 393);
            this.ReStartBtn.Name = "ReStartBtn";
            this.ReStartBtn.Size = new System.Drawing.Size(124, 45);
            this.ReStartBtn.TabIndex = 4;
            this.ReStartBtn.Text = "RESTART";
            this.ReStartBtn.UseVisualStyleBackColor = false;
            this.ReStartBtn.Click += new System.EventHandler(this.ReStartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 375);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReStartBtn);
            this.Controls.Add(this.FireAwayBtn);
            this.Controls.Add(this.FireBtn);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Button FireBtn;
        private System.Windows.Forms.Button FireAwayBtn;
        private System.Windows.Forms.Button ReStartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

