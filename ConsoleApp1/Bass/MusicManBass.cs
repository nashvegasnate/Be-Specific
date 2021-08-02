using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_Specific.Bass
{
    class MusicManBass : BassBase
    {
        public BassColor Color { get; set; }
        public bool IsFretted { get; set; }

        public override void Play()
        {
            Console.WriteLine("This bass plays fast and smoothly.");
        }

        public void Funky()
        {
            Console.WriteLine("The funkiest tone one can find in a bass.");
        }
    }
}
