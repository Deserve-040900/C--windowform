namespace demo
{
    partial class Guide
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
            this.panelGuide = new System.Windows.Forms.Panel();
            this.panelRules = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuide
            // 
            this.panelGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGuide.BackColor = System.Drawing.Color.Bisque;
            this.panelGuide.Location = new System.Drawing.Point(120, 90);
            this.panelGuide.Name = "panelGuide";
            this.panelGuide.Size = new System.Drawing.Size(350, 400);
            this.panelGuide.TabIndex = 0;
            // 
            // panelRules
            // 
            this.panelRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRules.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelRules.Controls.Add(this.button1);
            this.panelRules.Location = new System.Drawing.Point(635, 90);
            this.panelRules.Name = "panelRules";
            this.panelRules.Size = new System.Drawing.Size(350, 400);
            this.panelRules.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.panelRules);
            this.Controls.Add(this.panelGuide);
            this.Name = "Guide";
            this.Text = "Guide";
            this.panelRules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuide;
        private System.Windows.Forms.Panel panelRules;
        private System.Windows.Forms.Button button1;
    }
}