using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Instrument
    {
        private bool hasStrings = true;
        private int numStrings;
        private bool usesFingers;
        private bool usesCord;
        private bool usesAmp;

       

        public bool HasStrings1
        {
            get
            {
                return hasStrings;
            }

            set
            {
                hasStrings = value;
            }
        }

        public int NumStrings
        {
            get
            {
                return numStrings;
            }

            set
            {
                numStrings = value;
            }
        }

        public bool UsesFingers
        {
            get
            {
                return usesFingers;
            }

            set
            {
                usesFingers = value;
            }
        }

        public bool UsesCord
        {
            get
            {
                return usesCord;
            }

            set
            {
                usesCord = value;
            }
        }

        public bool UsesAmp
        {
            get
            {
                return usesAmp;
            }

            set
            {
                usesAmp = value;
            }
        }

        /*  public Instrument 


          }*/


    }
}
