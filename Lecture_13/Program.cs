using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static Song CreateSong(string songName, int songLength, string author, uint year)
        {
            Song mySong = new Song(songName, songLength, author, year);
            return mySong;
        }

        static void PrintSong(Song song)
        {
            Console.WriteLine($"Song name:{song.SongName}");
            Console.WriteLine($"Song author:{song.Author}");
            Console.WriteLine($"Song length:{song.SongLength}");
            Console.WriteLine($"Song year:{song.Year}");
        }

        static object GetSongDate(Song song)
        {
            var mySong = new
            {
                Title = song.SongName,
                Minutes = song.SongLength,
                AlboYear = song.Year
            };
            return mySong;
        }
    }
}
