#include "youtube/youtubedl.h"
#include "metadata/editdata.h"


int main(){
    char url[64];
    strcpy(url,GetURL());
    DownloadMP3(url);
    runCSmetadata();
    remove("temp/temp.txt");
    remove("temp/temp2.txt");
    remove("temp/temp3.txt");
    remove("temp/artist.txt");
    remove("temp/album.txt");
    remove("temp/title.txt");


    return 0;
}