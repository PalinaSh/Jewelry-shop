using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(Master))]
    [XmlInclude(typeof(Jewelry))]
    [XmlInclude(typeof(DateTime))]
    public class Order
    {
        private double orderPrice;

        public Master Master { get; set; }
        public Jewelry Jewelry { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public string Status { get; set; }

        public Order() { }

        public Order(Master m, Jewelry j, DateTime b, DateTime e, string s)
        {
            Master = m;
            Jewelry = j;
            Begin = b;
            End = e;
            Status = s;
        }

        public double OrderPrice
        {
            get => orderPrice;
            set
            {
                orderPrice += Master.PriceHour * Jewelry.Complexity + Jewelry.JewelryPrice;
            }
        }
    }
}
