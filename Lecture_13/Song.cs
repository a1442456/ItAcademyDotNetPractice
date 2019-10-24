using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13
{
    class Song
    {
        private string _songName;
        private int _songLength;
        private string _author;
        private uint _year;

        public Song(string songName, int songLength, string author, uint year)
        {
            _songName = songName;
            _songLength = SongLength;
            _author = author;
            _year = year;
        }

        public uint Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int SongLength
        {
            get { return _songLength; }
            set { _songLength = value; }
        }


        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }

    }
}
