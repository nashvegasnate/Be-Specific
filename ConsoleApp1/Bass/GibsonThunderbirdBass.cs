using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_Specific.Bass
{
    class GibsonThunderbirdBass : BassBase
    {
        public bool IsRightHanded { get; set; }
        public int NumberOfKnobs { get; set; }

        public override void Play()
        {
            Console.WriteLine("This one is a little clunky, but it looks badass!");
        }
    }
}
