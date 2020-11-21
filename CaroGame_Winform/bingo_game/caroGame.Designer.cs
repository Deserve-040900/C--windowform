namespace bingo_game
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pnlDrawChessBoard = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pctBoxMark = new System.Windows.Forms.PictureBox();
            this.lbConfig = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbNotification = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbConfig = new System.Windows.Forms.TextBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.prgrBarCountDown = new System.Windows.Forms.ProgressBar();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrawChessBoard
            // 
            this.pnlDrawChessBoard.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlDrawChessBoard.Location = new System.Drawing.Point(24, 68);
            this.pnlDrawChessBoard.Name = "pnlDrawChessBoard";
            this.pnlDrawChessBoard.Size = new System.Drawing.Size(600, 555);
            this.pnlDrawChessBoard.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(652, 84);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 300);
            this.pnlLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pctBoxMark);
            this.panel.Controls.Add(this.lbConfig);
            this.panel.Controls.Add(this.lbPlayerName);
            this.panel.Controls.Add(this.lbNotification);
            this.panel.Controls.Add(this.btnConnect);
            this.panel.Controls.Add(this.txbConfig);
            this.panel.Controls.Add(this.txbPlayerName);
            this.panel.Location = new System.Drawing.Point(652, 399);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(307, 224);
            this.panel.TabIndex = 2;
            // 
            // pctBoxMark
            // 
            this.pctBoxMark.Location = new System.Drawing.Point(227, 24);
            this.pctBoxMark.Name = "pctBoxMark";
            this.pctBoxMark.Size = new System.Drawing.Size(80, 80);
            this.pctBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxMark.TabIndex = 4;
            this.pctBoxMark.TabStop = false;
            // 
            // lbConfig
            // 
            this.lbConfig.AutoSize = true;
            this.lbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfig.Location = new System.Drawing.Point(0, 56);
            this.lbConfig.Name = "lbConfig";
            this.lbConfig.Size = new System.Drawing.Size(86, 20);
            this.lbConfig.TabIndex = 3;
            this.lbConfig.Text = "IP Config";
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(0, 0);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(116, 20);
            this.lbPlayerName.TabIndex = 3;
            this.lbPlayerName.Text = "Player Name";
            // 
            // lbNotification
            // 
            this.lbNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNotification.Location = new System.Drawing.Point(0, 154);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(307, 70);
            this.lbNotification.TabIndex = 3;
            this.lbNotification.Text = "Thông báo";
            this.lbNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(41, 114);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connecting";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txbConfig
            // 
            this.txbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfig.Location = new System.Drawing.Point(0, 80);
            this.txbConfig.Name = "txbConfig";
            this.txbConfig.Size = new System.Drawing.Size(208, 27);
            this.txbConfig.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlayerName.Location = new System.Drawing.Point(0, 24);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(208, 27);
            this.txbPlayerName.TabIndex = 0;
            // 
            // prgrBarCountDown
            // 
            this.prgrBarCountDown.Location = new System.Drawing.Point(703, 28);
            this.prgrBarCountDown.Name = "prgrBarCountDown";
            this.prgrBarCountDown.Size = new System.Drawing.Size(200, 30);
            this.prgrBarCountDown.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.prgrBarCountDown);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlDrawChessBoard);
            this.Name = "Form";
            this.Text = "Caro Game";
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawChessBoard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbConfig;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txbConfig;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.PictureBox pctBoxMark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar prgrBarCountDown;
    }
}

