using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_Specific.Bass
{
    class FenderJazzBass : BassBase
    {
        public bool HasActivePickups { get; set; }
        public string CountryOfOrigin { get; set; }

        public override void Play()
        {
            Console.WriteLine("The narrowed width of the neck makes this bass easy to play.");
        }

        public void Jaco()
        {
            Console.WriteLine("Jaco Pastorius popularized the fretless version.");
        }
    }
}
