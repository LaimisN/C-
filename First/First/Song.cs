using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Song
    {
        public string nameName; //normal atributes tai yra kas surasyta
        public string album;
        public int number;
        public static int songCount = 0;

        public Song(string anameName, string aAlbum, int aNumber) //constructor oblect
        {
            nameName = anameName;
            album = aAlbum;
            number = aNumber;
            songCount++;
        }
    public int getSongCount()
        {
            return songCount;
        }
    }
}
