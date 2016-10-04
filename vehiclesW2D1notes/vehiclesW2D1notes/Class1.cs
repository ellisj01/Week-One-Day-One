using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclesW2D1notes
{
    public class vehicle
    {
        public vehicle()
        {
//empty constructor for now
        }

        private bool hasWheels = true;
        private int numWheels;
        private bool hasDoors;

        public bool HasWheels
        {
            get
            {
                return hasWheels;
            }
            
        }

        public bool hasDoors
        {
            get
            {
                return hasDoors;
            }
        }

        public int NumWheels
        {
            get
            {
                return numWheels;
            }

            set
            { value}
            {
                if (value < 1)
                {
                    numWheels = 1;
                         }
                numWheels = value;
            }
        }
    }
}
