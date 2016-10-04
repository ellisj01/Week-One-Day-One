using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
   public class GameConsole
    {
        private bool hasHDMIPort;
        private int numControllerport;
        private bool onlineCapability;
        private bool onlineFree;
        private string manufacturer;

        public bool HasHDMIPort
        {
            get
            {
                return hasHDMIPort;
            }

            set
            {
                hasHDMIPort = value;
            }
        }

        public int NumControllerport
        {
            get
            {
                return numControllerport;
            }

            set
            {
                numControllerport = value;
            }
        }

        public bool OnlineCapability
        {
            get
            {
                return onlineCapability;
            }

            set
            {
                onlineCapability = value;
            }
        }

        public bool OnlineFree
        {
            get
            {
                return onlineFree;
            }

            set
            {
                onlineFree = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public GameConsole()
        {

        }

        public GameConsole(bool temp)
        {
            HasHDMIPort = temp;
        }

        
    }
}
