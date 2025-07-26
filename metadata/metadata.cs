using System.Diagnostics;
using ATL;
using ATL.AudioData;

class Metadata
{
    public static void EditSongData()
    {
        string filepath = "SONGS/" + SpotifyData.YTsearch + ".mp3";
        Track track = new Track(filepath);
        track.Artist = SpotifyData.artist;
        track.Album = SpotifyData.album;
        track.Title = SpotifyData.title;
        track.Save();
    }
}