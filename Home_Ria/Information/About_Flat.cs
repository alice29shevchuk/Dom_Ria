using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class About_Flat
    {
        public int Floor { get; set; }
        public int CountRoom { get; set; }
        public double GeneralQuadrature { get; set; }
        public About_Flat()
        {
            Floor = 0;
            CountRoom = 0;
            GeneralQuadrature = 0.0;
        }

        public About_Flat(int floor, int countRoom, double generalQuadrature)
        {
            Floor = floor;
            CountRoom = countRoom;
            GeneralQuadrature = generalQuadrature;
        }
    }
}
