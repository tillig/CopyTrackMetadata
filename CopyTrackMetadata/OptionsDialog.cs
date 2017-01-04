using System;
using System.Windows.Forms;

namespace CopyTrackMetadata
{
	public partial class OptionsDialog : Form
	{
		public OptionsDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Gets the options from the dialog.
		/// </summary>
		/// <returns>A <see cref="CopyOptions"/> based on the selected items in the dialog.</returns>
		public CopyOptions GetOptions()
		{
			CopyOptions retVal = new CopyOptions();
			retVal.Album = album.Checked;
			retVal.AlbumArtist = albumArtist.Checked;
			retVal.Artist = artist.Checked;
			retVal.Artwork = artwork.Checked;
			retVal.BPM = bpm.Checked;
			retVal.Category = category.Checked;
			retVal.Comment = comment.Checked;
			retVal.Compilation = compilation.Checked;
			retVal.Composer = composer.Checked;
			retVal.Description = description.Checked;
			retVal.DiscCount = discCount.Checked;
			retVal.DiscNumber = discNumber.Checked;
			retVal.Enabled = enabled.Checked;
			retVal.EpisodeID = episodeId.Checked;
			retVal.EpisodeNumber = episodeNumber.Checked;
			retVal.EQ = eq.Checked;
			retVal.ExcludeFromShuffle = excludeFromShuffle.Checked;
			retVal.Finish = finish.Checked;
			retVal.Genre = genre.Checked;
			retVal.Grouping = grouping.Checked;
			retVal.LongDescription = longDescription.Checked;
			retVal.Lyrics = lyrics.Checked;
			retVal.Name = name.Checked;
			retVal.PartOfGaplessAlbum = partOfGaplessAlbum.Checked;
			retVal.PlayedCount = playedCount.Checked;
			retVal.PlayedDate = playedDate.Checked;
			retVal.PlaylistMembership = playlistMembership.Checked;
			retVal.Rating = rating.Checked;
			retVal.RememberBookmark = rememberBookmark.Checked;
			retVal.SeasonNumber = seasonNumber.Checked;
			retVal.Show = show.Checked;
			retVal.SkippedCount = skippedCount.Checked;
			retVal.SkippedDate = skippedDate.Checked;
			retVal.SortAlbum = sortAlbum.Checked;
			retVal.SortAlbumArtist = sortAlbumArtist.Checked;
			retVal.SortArtist = sortArtist.Checked;
			retVal.SortComposer = sortComposer.Checked;
			retVal.SortName = sortName.Checked;
			retVal.SortShow = sortShow.Checked;
			retVal.Start = start.Checked;
			retVal.TrackCount = trackCount.Checked;
			retVal.TrackNumber = trackNumber.Checked;
			retVal.VolumeAdjustment = volumeAdjustment.Checked;
			retVal.Year = year.Checked;
			return retVal;
		}

		/// <summary>
		/// Sets the dialog options with the specified values.
		/// </summary>
		/// <param name="options">The options to set the dialog with.</param>
		/// <exception cref="System.ArgumentNullException">
		/// Thrown if <paramref name="options"/> is <see langword="null"/>.
		/// </exception>
		public void SetOptions(CopyOptions options)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			album.Checked = options.Album;
			albumArtist.Checked = options.AlbumArtist;
			artist.Checked = options.Artist;
			artwork.Checked = options.Artwork;
			bpm.Checked = options.BPM;
			category.Checked = options.Category;
			comment.Checked = options.Comment;
			compilation.Checked = options.Compilation;
			composer.Checked = options.Composer;
			description.Checked = options.Description;
			discCount.Checked = options.DiscCount;
			discNumber.Checked = options.DiscNumber;
			enabled.Checked = options.Enabled;
			episodeId.Checked = options.EpisodeID;
			episodeNumber.Checked = options.EpisodeNumber;
			eq.Checked = options.EQ;
			excludeFromShuffle.Checked = options.ExcludeFromShuffle;
			finish.Checked = options.Finish;
			genre.Checked = options.Genre;
			grouping.Checked = options.Grouping;
			longDescription.Checked = options.LongDescription;
			lyrics.Checked = options.Lyrics;
			name.Checked = options.Name;
			partOfGaplessAlbum.Checked = options.PartOfGaplessAlbum;
			playedCount.Checked = options.PlayedCount;
			playedDate.Checked = options.PlayedDate;
			playlistMembership.Checked = options.PlaylistMembership;
			rating.Checked = options.Rating;
			rememberBookmark.Checked = options.RememberBookmark;
			seasonNumber.Checked = options.SeasonNumber;
			show.Checked = options.Show;
			skippedCount.Checked = options.SkippedCount;
			skippedDate.Checked = options.SkippedDate;
			sortAlbum.Checked = options.SortAlbum;
			sortAlbumArtist.Checked = options.SortAlbumArtist;
			sortArtist.Checked = options.SortArtist;
			sortComposer.Checked = options.SortComposer;
			sortName.Checked = options.SortName;
			sortShow.Checked = options.SortShow;
			start.Checked = options.Start;
			trackCount.Checked = options.TrackCount;
			trackNumber.Checked = options.TrackNumber;
			volumeAdjustment.Checked = options.VolumeAdjustment;
			year.Checked = options.Year;
		}

		/// <summary>
		/// Sets all of the checkbox options to a specific state.
		/// </summary>
		/// <param name="check"><see langword="true"/> to check all options; <see langword="false"/> to uncheck.</param>
		private void SetAllOptions(bool check)
		{
			album.Checked = check;
			albumArtist.Checked = check;
			artist.Checked = check;
			artwork.Checked = check;
			bpm.Checked = check;
			category.Checked = check;
			comment.Checked = check;
			compilation.Checked = check;
			composer.Checked = check;
			description.Checked = check;
			discCount.Checked = check;
			discNumber.Checked = check;
			enabled.Checked = check;
			episodeId.Checked = check;
			episodeNumber.Checked = check;
			eq.Checked = check;
			excludeFromShuffle.Checked = check;
			finish.Checked = check;
			genre.Checked = check;
			grouping.Checked = check;
			longDescription.Checked = check;
			lyrics.Checked = check;
			name.Checked = check;
			partOfGaplessAlbum.Checked = check;
			playedCount.Checked = check;
			playedDate.Checked = check;
			playlistMembership.Checked = check;
			rating.Checked = check;
			rememberBookmark.Checked = check;
			seasonNumber.Checked = check;
			show.Checked = check;
			skippedCount.Checked = check;
			skippedDate.Checked = check;
			sortAlbum.Checked = check;
			sortAlbumArtist.Checked = check;
			sortArtist.Checked = check;
			sortComposer.Checked = check;
			sortName.Checked = check;
			sortShow.Checked = check;
			start.Checked = check;
			trackCount.Checked = check;
			trackNumber.Checked = check;
			volumeAdjustment.Checked = check;
			year.Checked = check;
		}

		private void selectDeselectButton_Click(object sender, EventArgs e)
		{
			bool allChecked =
				(
				album.Checked &&
				albumArtist.Checked &&
				artist.Checked &&
				artwork.Checked &&
				bpm.Checked &&
				category.Checked &&
				comment.Checked &&
				compilation.Checked &&
				composer.Checked &&
				description.Checked &&
				discCount.Checked &&
				discNumber.Checked &&
				enabled.Checked &&
				episodeId.Checked &&
				episodeNumber.Checked &&
				eq.Checked &&
				excludeFromShuffle.Checked &&
				finish.Checked &&
				genre.Checked &&
				grouping.Checked &&
				longDescription.Checked &&
				lyrics.Checked &&
				name.Checked &&
				partOfGaplessAlbum.Checked &&
				playedCount.Checked &&
				playedDate.Checked &&
				playlistMembership.Checked &&
				rating.Checked &&
				rememberBookmark.Checked &&
				seasonNumber.Checked &&
				show.Checked &&
				skippedCount.Checked &&
				skippedDate.Checked &&
				sortAlbum.Checked &&
				sortAlbumArtist.Checked &&
				sortArtist.Checked &&
				sortComposer.Checked &&
				sortName.Checked &&
				sortShow.Checked &&
				start.Checked &&
				trackCount.Checked &&
				trackNumber.Checked &&
				volumeAdjustment.Checked &&
				year.Checked
				);

			if (allChecked)
			{
				this.SetAllOptions(false);
			}
			else
			{
				this.SetAllOptions(true);
			}
		}
	}
}