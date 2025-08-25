namespace Game_Caro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pictureCaro = new System.Windows.Forms.Panel();
            this.In4OfMatch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.pictureMark = new System.Windows.Forms.PictureBox();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.In4OfMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(947, 715);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pictureCaro
            // 
            this.pictureCaro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCaro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureCaro.BackgroundImage = global::Game_Caro.Properties.Resources.Caro1;
            this.pictureCaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCaro.Location = new System.Drawing.Point(974, 12);
            this.pictureCaro.Name = "pictureCaro";
            this.pictureCaro.Size = new System.Drawing.Size(364, 364);
            this.pictureCaro.TabIndex = 1;
            // 
            // In4OfMatch
            // 
            this.In4OfMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.In4OfMatch.Controls.Add(this.label1);
            this.In4OfMatch.Controls.Add(this.btLAN);
            this.In4OfMatch.Controls.Add(this.txbIP);
            this.In4OfMatch.Controls.Add(this.pictureMark);
            this.In4OfMatch.Controls.Add(this.pcbCoolDown);
            this.In4OfMatch.Controls.Add(this.txbPlayerName);
            this.In4OfMatch.Location = new System.Drawing.Point(974, 392);
            this.In4OfMatch.Name = "In4OfMatch";
            this.In4OfMatch.Size = new System.Drawing.Size(364, 335);
            this.In4OfMatch.TabIndex = 2;
            this.In4OfMatch.Paint += new System.Windows.Forms.PaintEventHandler(this.In4OfMatch_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win game";
            // 
            // btLAN
            // 
            this.btLAN.Location = new System.Drawing.Point(3, 88);
            this.btLAN.Name = "btLAN";
            this.btLAN.Size = new System.Drawing.Size(174, 23);
            this.btLAN.TabIndex = 4;
            this.btLAN.Text = "button1";
            this.btLAN.UseVisualStyleBackColor = true;
            this.btLAN.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(3, 60);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(174, 22);
            this.txbIP.TabIndex = 3;
            this.txbIP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureMark
            // 
            this.pictureMark.Location = new System.Drawing.Point(207, 3);
            this.pictureMark.Name = "pictureMark";
            this.pictureMark.Size = new System.Drawing.Size(139, 108);
            this.pictureMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMark.TabIndex = 2;
            this.pictureMark.TabStop = false;
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pcbCoolDown.Location = new System.Drawing.Point(3, 31);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(174, 23);
            this.pcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(3, 3);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(174, 22);
            this.txbPlayerName.TabIndex = 0;
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 745);
            this.Controls.Add(this.In4OfMatch);
            this.Controls.Add(this.pictureCaro);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GameCaro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.In4OfMatch.ResumeLayout(false);
            this.In4OfMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pictureCaro;
        private System.Windows.Forms.Panel In4OfMatch;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Button btLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pictureMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCoolDown;
    }
}

