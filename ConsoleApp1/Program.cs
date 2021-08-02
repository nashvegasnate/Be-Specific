using Be_Specific.Bass;
using System;
using System.Collections.Generic;

namespace Be_Specific
{
    class Program
    {
        static void Main(string[] args)
        {
            var fenderJazzBass = new FenderJazzBass();
            fenderJazzBass.HasActivePickups = true;
            fenderJazzBass.Jaco();

            var fleaBass = new MusicManBass();
            fleaBass.Color = BassColor.green;
            fleaBass.NumberOfStrings = 4;
            fleaBass.Funky();

            var tbirdBass = new GibsonThunderbirdBass();
            tbirdBass.IsRightHanded = true;
            tbirdBass.NumberOfKnobs = 3;
       

            var basses = new List<BassBase>() { fenderJazzBass, fleaBass, tbirdBass };
            foreach(var bass in basses)
            {
               
                bass.Play();
            }
        }
        
    }

}
