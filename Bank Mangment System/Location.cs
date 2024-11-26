using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangment_System
{
    public class Location
    {
        private string district;
        private string alley;
        private string house;

        public string District { get => district; set => district = value; }
        public string Alley { get => alley; set => alley = value; }
        public string House { get => house; set => house = value; }
    }
}
