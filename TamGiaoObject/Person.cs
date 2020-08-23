using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiaoObject
{
    public class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ID_Card Card { get; set; }
        public PGender Gender { get; set; }

        public enum PGender
        {
            MALE = 0,
            FEMALE = 1,
            OTHER = 2
        }

        public Person(string iD, string name, string phoneNumber, string email, string address, ID_Card card, PGender gender)
        {
            ID = iD;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Card = card;
            Gender = gender;
        }
    }
}
