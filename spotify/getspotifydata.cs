using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

class SpotifyData
{

    public static string artist;
    public static string album;
    public static string title;
    
    static string url;
    static string ID;

    public static string YTsearch;

    static int timeTried;

    static public async Task GetTrack()
    {
        Console.WriteLine("Enter Spotify URL!");
        url = Console.ReadLine();
        url = url.TrimEnd();
        ID = url.Substring(31, 22);


        TrackData();

        while (YTsearch == null)
        {
            int i = 1;
            i++;
        }

    }


    static public async Task TrackData()
    {
        var config = SpotifyClientConfig
        .CreateDefault()
        .WithAuthenticator(new ClientCredentialsAuthenticator("c794d3ea8e69496889c4e7b3964b4db7", "75fabc64e3db45099fa3a6443e6f3004"));

        var spotify = new SpotifyClient(config);

        Console.WriteLine("Getting Data..." + timeTried);
        var track = await spotify.Tracks.Get(ID);
        YTsearch = track.Name + " " + track.Artists[0].Name;
        artist = track.Artists[0].Name;
        album = track.Album.Name;
        title = track.Name;
        if (YTsearch.Length <= 1)
        {
            timeTried += 1;
            TrackData();

        }
        File.WriteAllText("temp/temp2.txt", "-o " + '"' + YTsearch + '"' + ' ');
        File.WriteAllText("temp/temp3.txt", YTsearch);
        File.WriteAllText("temp/artist.txt", artist);
        File.WriteAllText("temp/album.txt", album);
        File.WriteAllText("temp/title.txt", title);
    }


}