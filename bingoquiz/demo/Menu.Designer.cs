namespace demo
{
    partial class Menu
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
            this.panelChildform = new System.Windows.Forms.Panel();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildform.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildform
            // 
            this.panelChildform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildform.BackColor = System.Drawing.Color.MistyRose;
            this.panelChildform.Controls.Add(this.btnQuitGame);
            this.panelChildform.Controls.Add(this.btnStart);
            this.panelChildform.Controls.Add(this.btnGuide);
            this.panelChildform.Controls.Add(this.panelLogo);
            this.panelChildform.Location = new System.Drawing.Point(0, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(1112, 652);
            this.panelChildform.TabIndex = 0;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitGame.Location = new System.Drawing.Point(447, 573);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(250, 50);
            this.btnQuitGame.TabIndex = 0;
            this.btnQuitGame.Text = "QUIT GAME";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            // 
            // btnGuide
            // 
            this.btnGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuide.Location = new System.Drawing.Point(447, 489);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(250, 50);
            this.btnGuide.TabIndex = 0;
            this.btnGuide.Text = "GUIDE";
            this.btnGuide.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(447, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "NEW GAME";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogo.BackColor = System.Drawing.Color.Khaki;
            this.panelLogo.Location = new System.Drawing.Point(421, 53);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 300);
            this.panelLogo.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.panelChildform);
            this.Name = "Menu";
            this.Text = "Bingo Quiz";
            this.panelChildform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnStart;
    }
}

