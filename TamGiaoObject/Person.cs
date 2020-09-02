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
        public ID_Card Card { get; set; }
        public Utils.Gender Gender { get; set; }

    }

    public class Place
    {

    }
}
