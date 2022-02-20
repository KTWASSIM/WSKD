namespace WSDK
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Disable = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label2.Location = new System.Drawing.Point(265, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pictureBox2.Location = new System.Drawing.Point(60, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Windows Start  Key Disabler ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Disable
            // 
            this.Disable.BackColor = System.Drawing.Color.DarkCyan;
            this.Disable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Disable.ForeColor = System.Drawing.Color.White;
            this.Disable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Disable.Location = new System.Drawing.Point(60, 247);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(180, 36);
            this.Disable.TabIndex = 13;
            this.Disable.Text = "Disable";
            this.Disable.UseVisualStyleBackColor = false;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // Enable
            // 
            this.Enable.AccessibleName = "Enable";
            this.Enable.BackColor = System.Drawing.Color.DarkCyan;
            this.Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Enable.ForeColor = System.Drawing.Color.White;
            this.Enable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Enable.Location = new System.Drawing.Point(60, 183);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(180, 36);
            this.Enable.TabIndex = 12;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = false;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disable);
            this.Controls.Add(this.Enable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.Button Enable;
    }
}

