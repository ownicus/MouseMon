namespace MouseMon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDebug = new System.Windows.Forms.Label();
            this.progressBarMove = new System.Windows.Forms.ProgressBar();
            this.labelDelayTitle = new System.Windows.Forms.Label();
            this.labelSlideMax = new System.Windows.Forms.Label();
            this.labelSlideMin = new System.Windows.Forms.Label();
            this.trackBarMoveDelay = new System.Windows.Forms.TrackBar();
            this.numericInputDelay = new System.Windows.Forms.NumericUpDown();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timerMoveMouse = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCover = new System.Windows.Forms.GroupBox();
            this.labelCover = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDisableMouse = new System.Windows.Forms.CheckBox();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputDelay)).BeginInit();
            this.groupBoxCover.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.checkBoxDisableMouse);
            this.groupBoxControls.Controls.Add(this.checkBoxRandom);
            this.groupBoxControls.Controls.Add(this.labelStatus);
            this.groupBoxControls.Controls.Add(this.labelDebug);
            this.groupBoxControls.Controls.Add(this.progressBarMove);
            this.groupBoxControls.Controls.Add(this.labelDelayTitle);
            this.groupBoxControls.Controls.Add(this.labelSlideMax);
            this.groupBoxControls.Controls.Add(this.labelSlideMin);
            this.groupBoxControls.Controls.Add(this.trackBarMoveDelay);
            this.groupBoxControls.Controls.Add(this.numericInputDelay);
            this.groupBoxControls.Controls.Add(this.buttonStartStop);
            this.groupBoxControls.Location = new System.Drawing.Point(12, 27);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(365, 120);
            this.groupBoxControls.TabIndex = 0;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(287, 13);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(72, 17);
            this.checkBoxRandom.TabIndex = 10;
            this.checkBoxRandom.Text = "Random?";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(21, 29);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Paused";
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(286, 90);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(10, 13);
            this.labelDebug.TabIndex = 7;
            this.labelDebug.Text = ".";
            // 
            // progressBarMove
            // 
            this.progressBarMove.Location = new System.Drawing.Point(87, 80);
            this.progressBarMove.Name = "progressBarMove";
            this.progressBarMove.Size = new System.Drawing.Size(193, 23);
            this.progressBarMove.TabIndex = 8;
            // 
            // labelDelayTitle
            // 
            this.labelDelayTitle.AutoSize = true;
            this.labelDelayTitle.Location = new System.Drawing.Point(162, 13);
            this.labelDelayTitle.Name = "labelDelayTitle";
            this.labelDelayTitle.Size = new System.Drawing.Size(48, 13);
            this.labelDelayTitle.TabIndex = 6;
            this.labelDelayTitle.Text = "Delay (s)";
            // 
            // labelSlideMax
            // 
            this.labelSlideMax.AutoSize = true;
            this.labelSlideMax.Location = new System.Drawing.Point(258, 61);
            this.labelSlideMax.Name = "labelSlideMax";
            this.labelSlideMax.Size = new System.Drawing.Size(25, 13);
            this.labelSlideMax.TabIndex = 5;
            this.labelSlideMax.Text = "100";
            // 
            // labelSlideMin
            // 
            this.labelSlideMin.AutoSize = true;
            this.labelSlideMin.Location = new System.Drawing.Point(84, 61);
            this.labelSlideMin.Name = "labelSlideMin";
            this.labelSlideMin.Size = new System.Drawing.Size(19, 13);
            this.labelSlideMin.TabIndex = 4;
            this.labelSlideMin.Text = "10";
            // 
            // trackBarMoveDelay
            // 
            this.trackBarMoveDelay.Location = new System.Drawing.Point(87, 29);
            this.trackBarMoveDelay.Maximum = 100;
            this.trackBarMoveDelay.Minimum = 10;
            this.trackBarMoveDelay.Name = "trackBarMoveDelay";
            this.trackBarMoveDelay.Size = new System.Drawing.Size(196, 45);
            this.trackBarMoveDelay.TabIndex = 3;
            this.trackBarMoveDelay.TickFrequency = 10;
            this.trackBarMoveDelay.Value = 30;
            // 
            // numericInputDelay
            // 
            this.numericInputDelay.Location = new System.Drawing.Point(289, 48);
            this.numericInputDelay.Name = "numericInputDelay";
            this.numericInputDelay.Size = new System.Drawing.Size(42, 20);
            this.numericInputDelay.TabIndex = 2;
            this.numericInputDelay.ValueChanged += new System.EventHandler(this.numericInputTime_ValueChanged);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.Green;
            this.buttonStartStop.Location = new System.Drawing.Point(6, 48);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 55);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // timerMoveMouse
            // 
            this.timerMoveMouse.Tick += new System.EventHandler(this.timerMoveMouse_Tick);
            // 
            // groupBoxCover
            // 
            this.groupBoxCover.Controls.Add(this.labelCover);
            this.groupBoxCover.Location = new System.Drawing.Point(12, 153);
            this.groupBoxCover.Name = "groupBoxCover";
            this.groupBoxCover.Size = new System.Drawing.Size(365, 120);
            this.groupBoxCover.TabIndex = 1;
            this.groupBoxCover.TabStop = false;
            this.groupBoxCover.Text = "Process";
            this.groupBoxCover.Visible = false;
            // 
            // labelCover
            // 
            this.labelCover.BackColor = System.Drawing.Color.Black;
            this.labelCover.ForeColor = System.Drawing.Color.Lime;
            this.labelCover.Location = new System.Drawing.Point(7, 20);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(352, 90);
            this.labelCover.TabIndex = 0;
            this.labelCover.Text = "~";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHide,
            this.helpToolStripMenuItem,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemFile.Text = "Options";
            // 
            // toolStripMenuItemHide
            // 
            this.toolStripMenuItemHide.Name = "toolStripMenuItemHide";
            this.toolStripMenuItemHide.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemHide.Text = "Hide";
            this.toolStripMenuItemHide.Click += new System.EventHandler(this.toolStripMenuItemHide_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // checkBoxDisableMouse
            // 
            this.checkBoxDisableMouse.AutoSize = true;
            this.checkBoxDisableMouse.Location = new System.Drawing.Point(287, 29);
            this.checkBoxDisableMouse.Name = "checkBoxDisableMouse";
            this.checkBoxDisableMouse.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDisableMouse.TabIndex = 11;
            this.checkBoxDisableMouse.Text = "No Mouse";
            this.checkBoxDisableMouse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.groupBoxCover);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Data Daemon";
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputDelay)).EndInit();
            this.groupBoxCover.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Timer timerMoveMouse;
        private System.Windows.Forms.NumericUpDown numericInputDelay;
        private System.Windows.Forms.TrackBar trackBarMoveDelay;
        private System.Windows.Forms.Label labelSlideMax;
        private System.Windows.Forms.Label labelSlideMin;
        private System.Windows.Forms.Label labelDelayTitle;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBarMove;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.GroupBox groupBoxCover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDisableMouse;
    }
}

