#include <stdlib.h>
#include <stdio.h>
#include <string.h>

FILE *fptr;

char *GetURL();
char *GetURL(){
    system("dotnet run youtube/searchyt.cs");
    fptr = fopen("temp/temp.txt", "r");
    char str[64];
    fgets(str, 64, fptr);
    
    char *rtnstr = str;
    return rtnstr;
}


void DownloadMP3(char url[64]){
    fptr = fopen("temp/temp2.txt", "r");
    char str[64];
    fgets(str, 64, fptr);


    char cmd[256] = "cd SONGS  && ./ytdlp/yt-dlp_linux -x --audio-format mp3 --audio-quality 0 ";
    strcat(cmd, str);
    strcat(cmd, url);
    system(cmd);
}
