using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using YouTubeApiSharp;

class YoutubeGetURL
{

    static bool done;
    static string search = "";
   static void Main(string[] args)
        {
        if (args[0].Length < 19)
        {
            SpotifyData.YTsearch = File.ReadAllText("temp/temp3.txt");
            SpotifyData.artist = File.ReadAllText("temp/artist.txt");
            SpotifyData.album = File.ReadAllText("temp/album.txt");
            SpotifyData.title = File.ReadAllText("temp/title.txt");



            Metadata.EditSongData();
            Console.WriteLine("Metadata written!");
            Environment.Exit(0);
        }
        else
        {
            SpotifyData.GetTrack();
            search = SpotifyData.YTsearch;
            Search();
        }
            while (!done)
        {
            int i = 1;
            i++;
        }
        }

    static async void Search()
    {
        // Disable logging
        Log.setMode(false);

        // Keyword
        string querystring = search;

        // Number of result pages
        int querypages = 1;

        ////////////////////////////////
        // Start searching
        ////////////////////////////////

        VideoSearch videos = new VideoSearch();
        var items = await videos.GetVideos(querystring, querypages);

        Console.WriteLine("Youtube title is: " + items[0].getTitle());
        File.WriteAllText("temp/temp.txt", items[0].getUrl());
        done = true;

        }

}

