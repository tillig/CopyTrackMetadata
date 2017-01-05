# CopyTrackMetadata

Windows Forms utility that uses the iTunes SDK to copy metadata from one track to another.

As I find errors in tracks or re-rip tracks from lower-bitrate MP3 to Apple Lossless, I want to keep the metadata - title, artist, playlist membership, play count, and so on - as I update to use the fixed/new track. Much of this isn't exposed through the UI, so I wrote this utility.

[Corresponding blog article here.](http://www.paraesthesia.com/archive/2007/10/29/copytrackmetadata-copy-itunes-track-info.aspx/)

# Installation / Usage

1. Unzip the CopyTrackMetadata application into a folder.
2. Start iTunes.
3. Start the CopyTrackMetadata application.
4. If you want to select which metadata will get copied, go to the "Tools -> Options..." menu and make your selections.
5. In iTunes, select a source track.  In CopyTrackMetadata, click the "Make Selected Track Source" button.
6. In iTunes, select a destination track.  In CopyTrackMetadata, click the "Make Selected Track Destination" button.
7. In CopyTrackMetadata, click the "Copy Metadata" button.  The selected metadata will be copied from the source to the destination.
8. Click the "Clear Selections" button to start a new copy, or just select new source/destination tracks.

# Known Issues

- The iTunes UI doesn't react well to copying album ratings - only track ratings - so there is no option for copying album ratings.
- Copying album artwork is a little slow because you have to extract the artwork from the source into a file and then update the destination from that file. This can take several seconds.
- When you copy downloaded artwork from one track to another, the destination track doesn't know that the artwork was downloaded, so "Clear Downloaded Artwork" in iTunes will not clear the artwork.

# Screen Shots

Main Window

![Main Window](https://cloud.githubusercontent.com/assets/1156571/21692345/303fe84c-d331-11e6-8872-2246f6262966.png)

Options

![Options](https://cloud.githubusercontent.com/assets/1156571/21692353/39ba778e-d331-11e6-9235-254283ffa1a1.png)
