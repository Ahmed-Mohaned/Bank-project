using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangment_System
{
    public class Location
    {
        private int district;
        private int alley;
        private int house;

        public int District { get => district; set => district = value; }
        public int Alley { get => alley; set => alley = value; }
        public int House { get => house; set => house = value; }
    }
}
