using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangment_System
{
    public class AccountInfos
    {
        private Name name = new Name();  
        private Name motherName = new Name();  
        private string phoneNumber;
        private Birth birth = new Birth();  
        private string gender;
        private Location location = new Location(); 
        private string email;
        private string password;
        private string nationalIDCardPath;
        private string passportPath;
        private string residenceCardPath;
        private bool employee;
        private string photo;
        private decimal balance;
        private string cardNumber;

       
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Birth Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public Location Location { get => location; set => location = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string NationalIDCardPath { get => nationalIDCardPath; set => nationalIDCardPath = value; }
        public string PassportPath { get => passportPath; set => passportPath = value; }
        public string ResidenceCardPath { get => residenceCardPath; set => residenceCardPath = value; }
        public bool Employee { get => employee; set => employee = value; }
        public string Photo { get => photo; set => photo = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public Name Name { get => name; set => name = value; }
        public Name MotherName { get => motherName; set => motherName = value; }

        public string GenerateRandomCardNumber(int length)
        {
            Random random = new Random();
            string cardNumber = "";

            for (int i = 0; i < length; i++)
            {
                cardNumber += random.Next(0, 10); 
            }

            return cardNumber;
        }
    }
}
