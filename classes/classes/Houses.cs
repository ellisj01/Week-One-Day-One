using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Houses
    {
        private bool hasDoors = true;
        private int numDoors;
        private int numRooms;
        private bool hasPool;
        private bool hasChimney;

        public bool HasDoors
        {
            get
            {
                return hasDoors;
            }

            set
            {
                hasDoors = value;
            }
        }

        public int NumDoors
        {
            get
            {
                return numDoors;
            }

            set
            {
                numDoors = value;
            }
        }

        public int NumRooms
        {
            get
            {
                return numRooms;
            }

            set
            {
                numRooms = value;
            }
        }

        public bool HasPool
        {
            get
            {
                return hasPool;
            }

            set
            {
                hasPool = value;
            }
        }

        public bool HasChimney
        {
            get
            {
                return hasChimney;
            }

            set
            {
                hasChimney = value;
            }
        }

        public Houses ()
        {

        }
            public Houses (int doors)
        {

        }                                                                                     
    }
}
