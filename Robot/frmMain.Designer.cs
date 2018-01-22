namespace Robot
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.grpbxReplay = new System.Windows.Forms.GroupBox();
            this.ckbxLoop = new System.Windows.Forms.CheckBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.bntPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDataFill = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lstbxInstructions = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.grpbxReplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(484, 456);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGo10
            // 
            this.btnGo10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo10.Location = new System.Drawing.Point(174, 281);
            this.btnGo10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(48, 23);
            this.btnGo10.TabIndex = 16;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.UseVisualStyleBackColor = true;
            this.btnGo10.Click += new System.EventHandler(this.btnGo10_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Location = new System.Drawing.Point(14, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 216);
            this.panel1.TabIndex = 15;
            // 
            // lblRobot
            // 
            this.lblRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRobot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRobot.Location = new System.Drawing.Point(100, 100);
            this.lblRobot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(12, 12);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            this.btnGo1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo1.Location = new System.Drawing.Point(22, 281);
            this.btnGo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(48, 23);
            this.btnGo1.TabIndex = 14;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(134, 281);
            this.btnE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(24, 23);
            this.btnE.TabIndex = 13;
            this.btnE.Text = "E";
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(86, 281);
            this.btnW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(24, 23);
            this.btnW.TabIndex = 12;
            this.btnW.Text = "W";
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(110, 305);
            this.btnS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(24, 23);
            this.btnS.TabIndex = 11;
            this.btnS.Text = "S";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(110, 257);
            this.btnN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(24, 23);
            this.btnN.TabIndex = 10;
            this.btnN.Text = "N";
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(22, 9);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(100, 16);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(291, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(272, 23);
            this.progressBar.TabIndex = 18;
            // 
            // grpbxReplay
            // 
            this.grpbxReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxReplay.Controls.Add(this.ckbxLoop);
            this.grpbxReplay.Controls.Add(this.lblSpeed);
            this.grpbxReplay.Controls.Add(this.tbSpeed);
            this.grpbxReplay.Location = new System.Drawing.Point(237, 389);
            this.grpbxReplay.Name = "grpbxReplay";
            this.grpbxReplay.Size = new System.Drawing.Size(326, 61);
            this.grpbxReplay.TabIndex = 20;
            this.grpbxReplay.TabStop = false;
            this.grpbxReplay.Text = "groupBox1";
            // 
            // ckbxLoop
            // 
            this.ckbxLoop.AutoSize = true;
            this.ckbxLoop.Location = new System.Drawing.Point(236, 19);
            this.ckbxLoop.Name = "ckbxLoop";
            this.ckbxLoop.Size = new System.Drawing.Size(50, 17);
            this.ckbxLoop.TabIndex = 2;
            this.ckbxLoop.Text = "Loop";
            this.ckbxLoop.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(43, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(35, 13);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "label1";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(74, 10);
            this.tbSpeed.Maximum = 5;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(156, 45);
            this.tbSpeed.TabIndex = 0;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // bntPlay
            // 
            this.bntPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntPlay.Location = new System.Drawing.Point(402, 456);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(75, 23);
            this.bntPlay.TabIndex = 21;
            this.bntPlay.Text = "Play";
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(321, 456);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(240, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDataFill
            // 
            this.btnDataFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataFill.Location = new System.Drawing.Point(159, 456);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(75, 23);
            this.btnDataFill.TabIndex = 24;
            this.btnDataFill.Text = "DataFill";
            this.btnDataFill.UseVisualStyleBackColor = true;
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(237, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 25;
            this.lblProgress.Text = "Progress";
            // 
            // lstbxInstructions
            // 
            this.lstbxInstructions.FormattingEnabled = true;
            this.lstbxInstructions.Location = new System.Drawing.Point(237, 33);
            this.lstbxInstructions.Name = "lstbxInstructions";
            this.lstbxInstructions.Size = new System.Drawing.Size(326, 355);
            this.lstbxInstructions.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(572, 491);
            this.Controls.Add(this.lstbxInstructions);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bntPlay);
            this.Controls.Add(this.grpbxReplay);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.lblPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 530);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jamie The Robot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.grpbxReplay.ResumeLayout(false);
            this.grpbxReplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox grpbxReplay;
        private System.Windows.Forms.CheckBox ckbxLoop;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDataFill;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ListBox lstbxInstructions;
        private System.Windows.Forms.Timer timer1;
    }
}

