namespace LabelGUI
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.PaleGreen;
            this.lb1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lb1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb1.Location = new System.Drawing.Point(244, 198);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(166, 109);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Take a depth breath";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.Black;
            this.lb2.Cursor = System.Windows.Forms.Cursors.Help;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Yellow;
            this.lb2.Location = new System.Drawing.Point(104, 91);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(147, 46);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Target form2";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(499, 444);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label GUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}

