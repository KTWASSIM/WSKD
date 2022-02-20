namespace WSDK
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.Disable = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "  To apply changes you should\r\n re-sign into your windows user ";
            // 
            // Disable
            // 
            this.Disable.BackColor = System.Drawing.Color.DarkCyan;
            this.Disable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Disable.ForeColor = System.Drawing.Color.White;
            this.Disable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Disable.Location = new System.Drawing.Point(155, 96);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(97, 39);
            this.Disable.TabIndex = 11;
            this.Disable.Text = "Later";
            this.Disable.UseVisualStyleBackColor = false;
            this.Disable.Click += new System.EventHandler(this.Disable_Click_1);
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
            this.Enable.Location = new System.Drawing.Point(16, 96);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(97, 39);
            this.Enable.TabIndex = 10;
            this.Enable.Text = "Re-sign";
            this.Enable.UseVisualStyleBackColor = false;
            this.Enable.Click += new System.EventHandler(this.Enable_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disable);
            this.Controls.Add(this.Enable);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.Button Enable;
    }
}