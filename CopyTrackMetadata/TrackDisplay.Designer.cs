namespace CopyTrackMetadata
{
    partial class TrackDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.trackGroupBox = new System.Windows.Forms.GroupBox();
			this.locationValue = new System.Windows.Forms.Label();
			this.titleValue = new System.Windows.Forms.Label();
			this.typeValue = new System.Windows.Forms.Label();
			this.locationLabel = new System.Windows.Forms.Label();
			this.selectButton = new System.Windows.Forms.Button();
			this.typeLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.trackGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackGroupBox
			// 
			this.trackGroupBox.Controls.Add(this.locationValue);
			this.trackGroupBox.Controls.Add(this.titleValue);
			this.trackGroupBox.Controls.Add(this.typeValue);
			this.trackGroupBox.Controls.Add(this.locationLabel);
			this.trackGroupBox.Controls.Add(this.selectButton);
			this.trackGroupBox.Controls.Add(this.typeLabel);
			this.trackGroupBox.Controls.Add(this.titleLabel);
			this.trackGroupBox.Location = new System.Drawing.Point(0, 0);
			this.trackGroupBox.Name = "trackGroupBox";
			this.trackGroupBox.Size = new System.Drawing.Size(266, 114);
			this.trackGroupBox.TabIndex = 1;
			this.trackGroupBox.TabStop = false;
			this.trackGroupBox.Text = "Track";
			// 
			// locationValue
			// 
			this.locationValue.Location = new System.Drawing.Point(64, 46);
			this.locationValue.Name = "locationValue";
			this.locationValue.Size = new System.Drawing.Size(196, 36);
			this.locationValue.TabIndex = 7;
			// 
			// titleValue
			// 
			this.titleValue.Location = new System.Drawing.Point(64, 20);
			this.titleValue.Name = "titleValue";
			this.titleValue.Size = new System.Drawing.Size(196, 13);
			this.titleValue.TabIndex = 6;
			this.titleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// typeValue
			// 
			this.typeValue.Location = new System.Drawing.Point(64, 33);
			this.typeValue.Name = "typeValue";
			this.typeValue.Size = new System.Drawing.Size(196, 13);
			this.typeValue.TabIndex = 5;
			this.typeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// locationLabel
			// 
			this.locationLabel.AutoSize = true;
			this.locationLabel.Location = new System.Drawing.Point(7, 46);
			this.locationLabel.Name = "locationLabel";
			this.locationLabel.Size = new System.Drawing.Size(51, 13);
			this.locationLabel.TabIndex = 3;
			this.locationLabel.Text = "Location:";
			this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(10, 85);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(250, 23);
			this.selectButton.TabIndex = 2;
			this.selectButton.Text = "Select Track";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(7, 33);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(34, 13);
			this.typeLabel.TabIndex = 1;
			this.typeLabel.Text = "Type:";
			this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(7, 20);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(30, 13);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Title:";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TrackDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.trackGroupBox);
			this.Name = "TrackDisplay";
			this.Size = new System.Drawing.Size(269, 117);
			this.trackGroupBox.ResumeLayout(false);
			this.trackGroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox trackGroupBox;
        private System.Windows.Forms.Label locationValue;
        private System.Windows.Forms.Label titleValue;
        private System.Windows.Forms.Label typeValue;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
