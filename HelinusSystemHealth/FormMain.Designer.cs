namespace HelinusSystemHealth
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            statusStripMain = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelVer = new System.Windows.Forms.ToolStripStatusLabel();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxStatus = new System.Windows.Forms.GroupBox();
            numericUpDownTemp = new System.Windows.Forms.NumericUpDown();
            labelTime = new System.Windows.Forms.Label();
            buttonStop = new System.Windows.Forms.Button();
            buttonStart = new System.Windows.Forms.Button();
            contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            notifyIconMain = new System.Windows.Forms.NotifyIcon(components);
            panelControls = new System.Windows.Forms.Panel();
            labelLogoDetail = new System.Windows.Forms.Label();
            labelLogo = new System.Windows.Forms.Label();
            richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            statusStripMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemp).BeginInit();
            contextMenuStripMain.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelVer });
            statusStripMain.Location = new System.Drawing.Point(0, 462);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStripMain.Size = new System.Drawing.Size(488, 22);
            statusStripMain.TabIndex = 0;
            statusStripMain.Text = "Helinus System Health";
            // 
            // toolStripStatusLabelVer
            // 
            toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
            toolStripStatusLabelVer.Size = new System.Drawing.Size(26, 17);
            toolStripStatusLabelVer.Text = "Ver:";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripMain.Size = new System.Drawing.Size(488, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "Helinus System Health";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxStatus.Controls.Add(numericUpDownTemp);
            groupBoxStatus.Controls.Add(labelTime);
            groupBoxStatus.Controls.Add(buttonStop);
            groupBoxStatus.Controls.Add(buttonStart);
            groupBoxStatus.Location = new System.Drawing.Point(0, 64);
            groupBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Size = new System.Drawing.Size(487, 59);
            groupBoxStatus.TabIndex = 2;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status";
            // 
            // numericUpDownTemp
            // 
            numericUpDownTemp.Location = new System.Drawing.Point(69, 25);
            numericUpDownTemp.Name = "numericUpDownTemp";
            numericUpDownTemp.Size = new System.Drawing.Size(61, 23);
            numericUpDownTemp.TabIndex = 3;
            numericUpDownTemp.Value = new decimal(new int[] { 38, 0, 0, 0 });
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new System.Drawing.Point(12, 29);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(55, 15);
            labelTime.TabIndex = 2;
            labelTime.Text = "Temp(C):";
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new System.Drawing.Point(217, 23);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(136, 23);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemShow, aboutToolStripMenuItemAbout });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new System.Drawing.Size(185, 48);
            // 
            // toolStripMenuItemShow
            // 
            toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            toolStripMenuItemShow.Size = new System.Drawing.Size(184, 22);
            toolStripMenuItemShow.Text = "Show Helinus System Health";
            toolStripMenuItemShow.Click += toolStripMenuItemShow_Click;
            // 
            // aboutToolStripMenuItemAbout
            // 
            aboutToolStripMenuItemAbout.Name = "aboutToolStripMenuItemAbout";
            aboutToolStripMenuItemAbout.Size = new System.Drawing.Size(184, 22);
            aboutToolStripMenuItemAbout.Text = "About";
            aboutToolStripMenuItemAbout.Click += aboutToolStripMenuItem1_Click;
            // 
            // notifyIconMain
            // 
            notifyIconMain.ContextMenuStrip = contextMenuStripMain;
            notifyIconMain.Icon = (System.Drawing.Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "Helinus System Health";
            notifyIconMain.Visible = true;
            // 
            // panelControls
            // 
            panelControls.BackColor = System.Drawing.Color.FromArgb(15, 78, 132);
            panelControls.Controls.Add(labelLogoDetail);
            panelControls.Controls.Add(labelLogo);
            panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            panelControls.Location = new System.Drawing.Point(0, 24);
            panelControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControls.Name = "panelControls";
            panelControls.Size = new System.Drawing.Size(488, 37);
            panelControls.TabIndex = 4;
            // 
            // labelLogoDetail
            // 
            labelLogoDetail.AutoSize = true;
            labelLogoDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogoDetail.ForeColor = System.Drawing.Color.Silver;
            labelLogoDetail.Location = new System.Drawing.Point(82, 14);
            labelLogoDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogoDetail.Name = "labelLogoDetail";
            labelLogoDetail.Size = new System.Drawing.Size(84, 12);
            labelLogoDetail.TabIndex = 3;
            labelLogoDetail.Text = "Helinus System Health";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogo.ForeColor = System.Drawing.Color.White;
            labelLogo.Location = new System.Drawing.Point(8, 6);
            labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new System.Drawing.Size(77, 22);
            labelLogo.TabIndex = 2;
            labelLogo.Text = "Helinus";
            // 
            // richTextBoxLogs
            // 
            richTextBoxLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxLogs.Location = new System.Drawing.Point(0, 129);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new System.Drawing.Size(487, 330);
            richTextBoxLogs.TabIndex = 5;
            richTextBoxLogs.Text = "";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(488, 484);
            Controls.Add(richTextBoxLogs);
            Controls.Add(panelControls);
            Controls.Add(groupBoxStatus);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Helinus System Health";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemp).EndInit();
            contextMenuStripMain.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVer;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItemAbout;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelLogoDetail;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
    }
}