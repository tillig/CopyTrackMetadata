using System;
using iTunesLib;

namespace CopyTrackMetadata
{
	public class MetadataCopyUtility
	{
		/// <summary>
		/// Copies the metadata attributes from one track to another.
		/// </summary>
		/// <param name="source">The track to copy attributes FROM.</param>
		/// <param name="destination">The track to copy attributes TO.</param>
		/// <param name="options">The options of which metadata to copy.</param>
		public static void CopyMetadata(IITFileOrCDTrack source, IITFileOrCDTrack destination, CopyOptions options)
		{
			ValidateCopyParameters(source, destination);
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}

			// Metadata that affects the file location
			if (options.Album)
			{
				destination.Album = source.Album ?? "";
			}
			if (options.Artist)
			{
				destination.Artist = source.Artist ?? "";
			}
			if (options.DiscCount)
			{
				destination.DiscCount = source.DiscCount;
			}
			if (options.DiscNumber)
			{
				destination.DiscNumber = source.DiscNumber;
			}
			if (options.Name)
			{
				destination.Name = source.Name ?? "";
			}
			if (options.TrackCount)
			{
				destination.TrackCount = source.TrackCount;
			}
			if (options.TrackNumber)
			{
				destination.TrackNumber = source.TrackNumber;
			}

			// Simple metadata copy
			if (options.AlbumArtist)
			{
				destination.AlbumArtist = source.AlbumArtist ?? "";
			}
			if (options.BPM)
			{
				destination.BPM = source.BPM;
			}
			if (options.Category)
			{
				destination.Category = source.Category ?? "";
			}
			if (options.Comment)
			{
				destination.Comment = source.Comment ?? "";
			}
			if (options.Compilation)
			{
				destination.Compilation = source.Compilation;
			}
			if (options.Composer)
			{
				destination.Composer = source.Composer ?? "";
			}
			if (options.Description)
			{
				destination.Description = source.Description ?? "";
			}
			if (options.Enabled)
			{
				destination.Enabled = source.Enabled;
			}
			if (options.EpisodeID)
			{
				destination.EpisodeID = source.EpisodeID ?? "";
			}
			if (options.EpisodeNumber)
			{
				destination.EpisodeNumber = source.EpisodeNumber;
			}
			if (options.EQ)
			{
				destination.EQ = source.EQ ?? "";
			}
			if (options.ExcludeFromShuffle)
			{
				destination.ExcludeFromShuffle = source.ExcludeFromShuffle;
			}
			if (options.Finish && (source.Duration != source.Finish))
			{
				// Only set the Finish if it's not at the end of the track.
				destination.Finish = source.Finish;
			}
			if (options.Genre)
			{
				destination.Genre = source.Genre ?? "";
			}
			if (options.Grouping)
			{
				destination.Grouping = source.Grouping ?? "";
			}
			if (options.LongDescription)
			{
				destination.LongDescription = source.LongDescription ?? "";
			}
			if (options.Lyrics)
			{
				destination.Lyrics = source.Lyrics ?? "";
			}
			if (options.PartOfGaplessAlbum)
			{
				destination.PartOfGaplessAlbum = source.PartOfGaplessAlbum;
			}
			if (options.PlayedCount)
			{
				destination.PlayedCount = source.PlayedCount;
			}
			if (options.PlayedDate)
			{
				destination.PlayedDate = source.PlayedDate;
			}
			if (options.Rating)
			{
				destination.Rating = source.Rating;
			}
			if (options.RememberBookmark)
			{
				destination.RememberBookmark = source.RememberBookmark;
			}
			if (options.SeasonNumber)
			{
				destination.SeasonNumber = source.SeasonNumber;
			}
			if (options.Show)
			{
				destination.Show = source.Show ?? "";
			}
			if (options.SkippedCount)
			{
				destination.SkippedCount = source.SkippedCount;
			}
			if (options.SkippedDate)
			{
				destination.SkippedDate = source.SkippedDate;
			}
			if (options.SortAlbum)
			{
				destination.SortAlbum = source.SortAlbum ?? "";
			}
			if (options.SortAlbumArtist)
			{
				destination.SortAlbumArtist = source.SortAlbumArtist ?? "";
			}
			if (options.SortArtist)
			{
				destination.SortArtist = source.SortArtist ?? "";
			}
			if (options.SortComposer)
			{
				destination.SortComposer = source.SortComposer ?? "";
			}
			if (options.SortName)
			{
				destination.SortName = source.SortName ?? "";
			}
			if (options.SortShow)
			{
				destination.SortShow = source.SortShow ?? "";
			}
			if (options.Start && (source.Start != 0))
			{
				// Only set the Start if it's not at the beginning of the track.
				destination.Start = source.Start;
			}
			if (options.VolumeAdjustment)
			{
				destination.VolumeAdjustment = source.VolumeAdjustment;
			}
			if (options.Year)
			{
				destination.Year = source.Year;
			}

			// Excluded:
			// Copying the Album Rating in iTunes 7.4.1 causes the iTunes UI
			// to freak out and stop displaying the individual song ratings
			// for all songs on that album.
			//if (destination.AlbumRating)
			//{
			//    destination.AlbumRating = source.AlbumRating;
			//}

			// Artwork is harder - clear the destination track's artwork, then
			// write each souce item to a temp file and add
			// to destination from the files.
			if (options.Artwork)
			{
				IITArtworkCollection destinationOriginalArtworkCollection = destination.Artwork;
				if (destinationOriginalArtworkCollection != null && destinationOriginalArtworkCollection.Count > 0)
				{
					// Remove in reverse order so the collection enumerator doesn't shift
					for (int i = destinationOriginalArtworkCollection.Count; i > 0; i--)
					{
						IITArtwork destinationOriginalArtwork = destinationOriginalArtworkCollection[i];
						destinationOriginalArtwork.Delete();
					}
				}

				IITArtworkCollection sourceArtworkCollection = source.Artwork;
				if (sourceArtworkCollection != null && sourceArtworkCollection.Count > 0)
				{
					foreach (IITArtwork sourceArtwork in sourceArtworkCollection)
					{
						string tempFilePath = System.IO.Path.GetTempFileName();
						try
						{
							sourceArtwork.SaveArtworkToFile(tempFilePath);
							destination.AddArtworkFromFile(tempFilePath);
						}
						finally
						{
							if (System.IO.File.Exists(tempFilePath))
							{
								System.IO.File.Delete(tempFilePath);
							}
						}
					}
				}
			}

			// Sync the library with the file info
			destination.UpdateInfoFromFile();
		}

		/// <summary>
		/// Copies the playlist membership from one track to another.
		/// </summary>
		/// <param name="source">The track to copy membership FROM.</param>
		/// <param name="destination">The track to copy membership TO.</param>
		/// <param name="playlists">The playlists to search for membership of the source track.</param>
		public static void CopyPlaylistMembership(IITFileOrCDTrack source, IITFileOrCDTrack destination, IITPlaylistCollection playlists)
		{
			ValidateCopyParameters(source, destination);
			if (playlists == null || playlists.Count == 0)
			{
				return;
			}

			foreach (IITPlaylist playlist in playlists)
			{
				IITUserPlaylist userPlaylist = FilterValidPlaylist(playlist);
				if (userPlaylist == null)
				{
					continue;
				}
				if (IsMemberOfPlaylist(source, userPlaylist) && !IsMemberOfPlaylist(destination, userPlaylist))
				{
					// Add the destination to playlists that the source is in
					// but only if the destination isn't already there.
					object castDestination = (object)destination;
					userPlaylist.AddTrack(ref castDestination);
				}
			}
		}

		/// <summary>
		/// Filters out playlists that don't get items copied into them.
		/// </summary>
		/// <param name="playlist">The playlist to filter.</param>
		/// <returns>
		/// A <see cref="iTunesLib.IITUserPlaylist"/> version of <paramref name="playlist"/>
		/// if the membership of a track can be copied into it; <see langword="null"/>
		/// if the playlist should be ignored.
		/// </returns>
		private static IITUserPlaylist FilterValidPlaylist(IITPlaylist playlist)
		{
			IITUserPlaylist retval = playlist as IITUserPlaylist;
			if (retval == null || retval.Kind != ITPlaylistKind.ITPlaylistKindUser || retval.Smart || retval.SpecialKind != ITUserPlaylistSpecialKind.ITUserPlaylistSpecialKindNone)
			{
				return null;
			}
			return retval;
		}

		/// <summary>
		/// Determines if a given track is a member of a playlist.
		/// </summary>
		/// <param name="track">The track to find in the playlist.</param>
		/// <param name="playlist">The playlist to search.</param>
		/// <returns>
		/// <see langword="true"/> if <paramref name="track"/> is a member of
		/// <paramref name="playlist"/>; <see langword="false"/> if not.
		/// </returns>
		/// <exception cref="System.ArgumentNuullException">
		/// Thrown if <paramref name="track"/> or <paramref name="playlist"/>
		/// are <see langword="null"/>.
		/// </exception>
		private static bool IsMemberOfPlaylist(IITTrack track, IITPlaylist playlist)
		{
			if (track == null)
			{
				throw new ArgumentNullException("track");
			}
			if (playlist == null)
			{
				throw new ArgumentNullException("playlist");
			}

			IITTrackCollection searchResult = playlist.Search(track.Name, ITPlaylistSearchField.ITPlaylistSearchFieldSongNames);
			if (searchResult != null)
			{
				foreach (IITTrack member in searchResult)
				{
					if (member.TrackDatabaseID == track.TrackDatabaseID)
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Validates the parameters for a copy operation.
		/// </summary>
		/// <param name="source">The track to copy FROM.</param>
		/// <param name="destination">The track to copy TO.</param>
		/// <exception cref="System.ArgumentNullException">
		/// Thrown if <paramref name="source"/> or <paramref name="destination"/>
		/// are <see langword="null"/>.
		/// </exception>
		/// <exception cref="System.ArgumentException">
		/// Thrown if the <paramref name="source"/> and <paramref name="destination"/>
		/// are the same track.
		/// </exception>
		private static void ValidateCopyParameters(IITFileOrCDTrack source, IITFileOrCDTrack destination)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source", "Select a source track.");
			}
			if (destination == null)
			{
				throw new ArgumentNullException("destination", "Select a destination track.");
			}
			if (source.TrackDatabaseID == destination.TrackDatabaseID)
			{
				throw new ArgumentException("The source and destination tracks can't be the same.");
			}
		}
	}
}
