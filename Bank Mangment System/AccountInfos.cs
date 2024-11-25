using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangment_System
{
    public class AccountInfos
    {
        private Name name;
        private Name motherName;
        private string phoneNumber;
        private Birth birth;
        private bool gender;
        private Location location;
        private string email;
        private string password;
        private string nationalIDCardPath;
        private string passportPath;
        private string residenceCardPath;
        private bool employee;

        public Name Name { get => name; set => name = value; }
        public Name MotherName { get => motherName; set => motherName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Birth Birth { get => birth; set => birth = value; }
        public bool Gender { get => gender; set => gender = value; }
        public Location Location { get => location; set => location = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string NationalIDCardPath { get => nationalIDCardPath; set => nationalIDCardPath = value; }
        public string PassportPath { get => passportPath; set => passportPath = value; }
        public string ResidenceCardPath { get => residenceCardPath; set => residenceCardPath = value; }
        public bool Employee { get => employee; set => employee = value; }
    }
}
