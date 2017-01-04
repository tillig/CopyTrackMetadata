namespace CopyTrackMetadata
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.executeCopyButton = new System.Windows.Forms.Button();
			this.clearSelectionsButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.destinationTrackDisplay = new CopyTrackMetadata.TrackDisplay();
			this.sourceTrackDisplay = new CopyTrackMetadata.TrackDisplay();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// executeCopyButton
			// 
			this.executeCopyButton.Location = new System.Drawing.Point(148, 279);
			this.executeCopyButton.Name = "executeCopyButton";
			this.executeCopyButton.Size = new System.Drawing.Size(130, 23);
			this.executeCopyButton.TabIndex = 2;
			this.executeCopyButton.Text = "Copy Metadata";
			this.executeCopyButton.UseVisualStyleBackColor = true;
			this.executeCopyButton.Click += new System.EventHandler(this.executeCopyButton_Click);
			// 
			// clearSelectionsButton
			// 
			this.clearSelectionsButton.Location = new System.Drawing.Point(12, 279);
			this.clearSelectionsButton.Name = "clearSelectionsButton";
			this.clearSelectionsButton.Size = new System.Drawing.Size(130, 23);
			this.clearSelectionsButton.TabIndex = 3;
			this.clearSelectionsButton.Text = "Clear Selections";
			this.clearSelectionsButton.UseVisualStyleBackColor = true;
			this.clearSelectionsButton.Click += new System.EventHandler(this.clearSelectionsButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 305);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "Ready.";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
			this.toolStripStatusLabel1.Text = "Ready.";
			// 
			// destinationTrackDisplay
			// 
			this.destinationTrackDisplay.AutoSize = true;
			this.destinationTrackDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.destinationTrackDisplay.GroupBoxTitle = "Destination Track";
			this.destinationTrackDisplay.ITunes = null;
			this.destinationTrackDisplay.Location = new System.Drawing.Point(12, 156);
			this.destinationTrackDisplay.Name = "destinationTrackDisplay";
			this.destinationTrackDisplay.SelectButtonText = "Make Selected Track Destination";
			this.destinationTrackDisplay.Size = new System.Drawing.Size(269, 117);
			this.destinationTrackDisplay.TabIndex = 1;
			this.destinationTrackDisplay.Track = null;
			// 
			// sourceTrackDisplay
			// 
			this.sourceTrackDisplay.AutoSize = true;
			this.sourceTrackDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.sourceTrackDisplay.GroupBoxTitle = "Source Track";
			this.sourceTrackDisplay.ITunes = null;
			this.sourceTrackDisplay.Location = new System.Drawing.Point(12, 33);
			this.sourceTrackDisplay.Name = "sourceTrackDisplay";
			this.sourceTrackDisplay.SelectButtonText = "Make Selected Track Source";
			this.sourceTrackDisplay.Size = new System.Drawing.Size(269, 117);
			this.sourceTrackDisplay.TabIndex = 0;
			this.sourceTrackDisplay.Track = null;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "&Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 327);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.executeCopyButton);
			this.Controls.Add(this.destinationTrackDisplay);
			this.Controls.Add(this.sourceTrackDisplay);
			this.Controls.Add(this.clearSelectionsButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Copy iTunes Track Metadata";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TrackDisplay sourceTrackDisplay;
        private TrackDisplay destinationTrackDisplay;
        private System.Windows.Forms.Button executeCopyButton;
        private System.Windows.Forms.Button clearSelectionsButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

    }
}

