using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2.Classes
{
    [Serializable]
    public class Master: Person
    {
        public double PriceHour { get; set; }
        public double Rating { get; set; }
        public int Busy { get; set; }
        public string Comment { get; set; }

        public Master() { }

        public Master(double priceHour, double rating, string name, string surname, DateTime birthday)
            : base(name, surname, birthday)
        {
            PriceHour = priceHour;
            Rating = rating;
        }

        public Master(double priceHour, double rating, int busy, string comment, string name, string surname, DateTime birthday)
            : base(name, surname, birthday)
        {
            PriceHour = priceHour;
            Rating = rating;
            Busy = busy;
            Comment = comment;
        }


    }
}
