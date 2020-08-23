using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiaoObject
{
    public class ID_Card
    {
        public string Number { get; set; }
        public string PlaceOfCard { get; set; }
        public DateTime DateOfCard { get; set; }

        public bool isValidNumber { get; set; }

        public ID_Card(string number, string placeOfCard, DateTime dateOfCard)
        {
            Number = number;
            PlaceOfCard = placeOfCard;
            DateOfCard = dateOfCard;
            if (number.Count() == 6 || number.Count() == 9)
            {
                isValidNumber = true;
            }
            else
            {
                isValidNumber = false;
            }
        }
    }
}
