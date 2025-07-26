#include "youtube/youtubedl.h"
#include "metadata/editdata.h"


int main(){
    char url[64];
    strcpy(url,GetURL());
    DownloadMP3(url);
    runCSmetadata();
    remove("temp.txt");
    remove("temp2.txt");
    remove("temp3.txt");
    remove("artist.txt");
    remove("album.txt");
    remove("title.txt");


    return 0;
}