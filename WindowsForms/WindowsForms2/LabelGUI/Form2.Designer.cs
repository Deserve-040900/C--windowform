namespace LabelGUI
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
            this.lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.Red;
            this.lb3.Location = new System.Drawing.Point(106, 194);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(305, 168);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "200 câu hỏi dùng cho sát hạch cấp giấy phép lái xe Mô Tô 2 bánh A1";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 432);
            this.Controls.Add(this.lb3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lb3;
    }
}