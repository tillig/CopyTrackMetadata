using System;

namespace CopyTrackMetadata
{
	/// <summary>
	/// Individual options for what metadata to copy from track to track.
	/// </summary>
	public class CopyOptions
	{
		public bool Album = true;
		public bool AlbumArtist = true;
		//public bool AlbumRating = true;
		public bool Artist = true;
		public bool Artwork = true;
		public bool BPM = true;
		public bool Category = true;
		public bool Comment = true;
		public bool Compilation = true;
		public bool Composer = true;
		public bool Description = true;
		public bool DiscCount = true;
		public bool DiscNumber = true;
		public bool Enabled = true;
		public bool EpisodeID = true;
		public bool EpisodeNumber = true;
		public bool EQ = true;
		public bool ExcludeFromShuffle = true;
		public bool Finish = true;
		public bool Genre = true;
		public bool Grouping = true;
		public bool LongDescription = true;
		public bool Lyrics = true;
		public bool Name = true;
		public bool PartOfGaplessAlbum = true;
		public bool PlayedCount = true;
		public bool PlayedDate = true;
		public bool PlaylistMembership = true;
		public bool Rating = true;
		public bool RememberBookmark = true;
		public bool SeasonNumber = true;
		public bool Show = true;
		public bool SkippedCount = true;
		public bool SkippedDate = true;
		public bool SortAlbum = true;
		public bool SortAlbumArtist = true;
		public bool SortArtist = true;
		public bool SortComposer = true;
		public bool SortName = true;
		public bool SortShow = true;
		public bool Start = true;
		public bool TrackCount = true;
		public bool TrackNumber = true;
		public bool VolumeAdjustment = true;
		public bool Year = true;
	}
}
