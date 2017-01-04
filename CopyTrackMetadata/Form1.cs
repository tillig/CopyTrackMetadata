using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using iTunesLib;

namespace CopyTrackMetadata
{
    public partial class Form1 : Form
	{
		#region Variables

		/// <summary>
		/// References the iTunes application object to perform operations on.
		/// </summary>
		private IiTunes _itunes;

		/// <summary>
		/// Default text that appears in the status bar.
		/// </summary>
		private const string DefaultStatusText = "Ready.";

		/// <summary>
		/// The options used for copying metadata.
		/// </summary>
		private CopyOptions options = new CopyOptions();

		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="Form1"/> class.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Sets up the reference to the iTunes object to act on.
		/// </para>
		/// </remarks>
		public Form1()
        {
            InitializeComponent();
			this._itunes = new iTunesLib.iTunesAppClass();
			this.sourceTrackDisplay.ITunes = this._itunes;
			this.destinationTrackDisplay.ITunes = this._itunes;
        }

		/// <summary>
		/// Handles the "Clear Selections" button click event.
		/// </summary>
		/// <param name="sender">Source of the event.</param>
		/// <param name="e">Event arguments.</param>
		private void clearSelectionsButton_Click(object sender, EventArgs e)
		{
			this.sourceTrackDisplay.Track = null;
			this.destinationTrackDisplay.Track = null;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
				if (this._itunes != null)
				{
					try
					{
						while (System.Runtime.InteropServices.Marshal.ReleaseComObject(this._itunes) > 0) { };
					}
					finally
					{
						this._itunes = null;
					}
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// Handles the "Copy Metadata" button click event.
		/// </summary>
		/// <param name="sender">Source of the event.</param>
		/// <param name="e">Event arguments.</param>
		private void executeCopyButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.toolStripStatusLabel1.Text = "Copying source metadata to destination...";
				MetadataCopyUtility.CopyMetadata(this.sourceTrackDisplay.Track, this.destinationTrackDisplay.Track, this.options);
				if (options.PlaylistMembership)
				{
					this.toolStripStatusLabel1.Text = "Copying source playlist membership to destination...";
					MetadataCopyUtility.CopyPlaylistMembership(this.sourceTrackDisplay.Track, this.destinationTrackDisplay.Track, this._itunes.LibrarySource.Playlists);
				}
				MessageBox.Show("Metadata copied from source to destination.", "Metadata Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.sourceTrackDisplay.RefreshView();
				this.destinationTrackDisplay.RefreshView();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error Copying Metadata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				System.Diagnostics.Debug.WriteLine(err);
			}
			finally
			{
				this.toolStripStatusLabel1.Text = DefaultStatusText;
			}
		}

		/// <summary>
		/// Handles the "File - Exit" menu item click event.
		/// </summary>
		/// <param name="sender">Source of the event.</param>
		/// <param name="e">Event arguments.</param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Handles the "Tools - Options" menu item click event.
		/// </summary>
		/// <param name="sender">Source of the event.</param>
		/// <param name="e">Event arguments.</param>
		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OptionsDialog dialog = new OptionsDialog();
			dialog.SetOptions(this.options);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this.options = dialog.GetOptions();
			}
		}

	}
}