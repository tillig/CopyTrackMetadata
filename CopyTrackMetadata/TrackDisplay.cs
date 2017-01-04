using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using iTunesLib;

namespace CopyTrackMetadata
{
	public partial class TrackDisplay : UserControl
	{
		private IiTunes _itunes = null;
		private IITFileOrCDTrack _track = null;

		/// <summary>
		/// Gets or sets the title text for the group box.
		/// </summary>
		/// <value>
		/// The <see cref="System.String"/> that appears above the control
		/// group box.
		/// </value>
		public string GroupBoxTitle
		{
			get
			{
				return this.trackGroupBox.Text;
			}
			set
			{
				this.trackGroupBox.Text = value;
			}
		}

		/// <summary>
		/// Gets or sets the iTunes application instance.
		/// </summary>
		/// <value>
		/// The iTunes application instance that will be acted on.
		/// </value>
		public IiTunes ITunes
		{
			get
			{
				return _itunes;
			}
			set
			{
				_itunes = value;
			}
		}

		/// <summary>
		/// Gets or sets the select button text.
		/// </summary>
		/// <value>
		/// The <see cref="System.String"/> that displays on the control select button.
		/// </value>
		public string SelectButtonText
		{
			get
			{
				return this.selectButton.Text;
			}
			set
			{
				this.selectButton.Text = value;
			}
		}

		/// <summary>
		/// Gets or sets the track this control refers to.
		/// </summary>
		/// <value>
		/// The iTunes track being displayed and acted on.
		/// </value>
		public IITFileOrCDTrack Track
		{
			get
			{
				return _track;
			}
			set
			{
				_track = value;
				this.RefreshView();
			}
		}

		/// <summary>
		/// Initializes a new instances of <see cref="TrackDisplay"/>.
		/// </summary>
		public TrackDisplay()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Updates the form labels that display the track information.
		/// </summary>
		public void RefreshView()
		{
			if (this.Track != null)
			{
				this.titleValue.Text = this.Track.Name;
				this.typeValue.Text = this.Track.KindAsString;
				this.locationValue.Text = this.Track.Location;
			}
			else
			{
				this.titleValue.Text = "";
				this.typeValue.Text = "";
				this.locationValue.Text = "";
			}
		}

		private void selectButton_Click(object sender, EventArgs e)
		{
			IITTrackCollection selected = this.ITunes.SelectedTracks;
			if (selected == null || selected.Count != 1)
			{
				System.Windows.Forms.MessageBox.Show("You must select one and only one track.", "Select One Track Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			// IITTrackCollection indexes start at 1.
			IITFileOrCDTrack selectedTrack = selected[1] as IITFileOrCDTrack;
			if (selectedTrack == null)
			{
				System.Windows.Forms.MessageBox.Show("You must select a track from a file or CD. URL tracks are not supported.", "Select a File or CD Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Track = selectedTrack;
		}
	}
}
