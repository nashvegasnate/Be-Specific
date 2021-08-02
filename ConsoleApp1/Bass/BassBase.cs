using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_Specific.Bass
{
    abstract class BassBase
    {
        public bool IsElectric { get; set; }
        public int NumberOfStrings { get; set; }
        public BassColor Color { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("This bass has a killer low-end and crisp mids.");
        }
        //each bass will be able to do an indivual version of Play due to the use of the abstract void
        public abstract void Play();
    }
}
