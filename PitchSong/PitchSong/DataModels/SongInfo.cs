using System;
using System.Collections.Generic;
using System.Text;

namespace PitchSong.DataModels
{
    public class SongInfo
    {
        private string status;
        public string Name { get; set; }
        public string Status 
        {
            get { return status; }
            set
            {
                if (value == "C" || value == "c" || value == "C#" || value == "c#" ||
                    value == "D" || value == "d" || value == "Db" || value == "db" || value == "D#" || value == "d#" ||
                    value == "E" || value == "e" || value == "Eb" || value == "eb" ||
                    value == "F" || value == "f" || value == "F#" || value == "f#" ||
                    value == "G" || value == "g" || value == "g#" || value == "G#" || value == "gb" || value == "Gb" ||
                    value == "A" || value == "a" || value == "A#" || value == "a#" || value == "Ab" || value == "ab" ||
                    value == "B" || value == "b" || value == "Bb" || value == "bb" || 
                    value == "Not Set")
                {
                    status = value;
                }
                else
                {
                    status = "Not Set";
                }
            } 
        }
        
    }
}
