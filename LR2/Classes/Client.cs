using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(ObservableCollection<Order>))]
    public class Client : Person
    {
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<Jewelry> Basket { get; set; }
        private long highPrice = 500;
        private long highestPrice = 1500;
        private double oneDiscount = 0.1;
        private static double regularDiscount = 0.15;
        private static long id;
        private static double priceAllOrders;

        public double PriceAllOrders
        {
            get
            {
                for (int i = 0; i < Orders.Count; ++i)
                    priceAllOrders += Orders[i].OrderPrice;
                return priceAllOrders;
            }
            set
            {
                priceAllOrders = value;
            }
        }

        //[XmlIgnore]
        //public double PriceAllBasket
        //{
        //    get
        //    {
        //        for (int i = 0; i < Basket.Count; ++i)
        //            priceAllBasket += Basket[i].OrderPrice;
        //        return priceAllBasket;
        //    }
        //}

        public long ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [XmlIgnore]
        public double RegularDiscount
        {
            get => regularDiscount;
            private set
            {
                if (priceAllOrders > highestPrice)
                    regularDiscount = 0.2;
            }
        }

        public Client()
        {
            Orders = new ObservableCollection<Order>();
            Basket = new ObservableCollection<Jewelry>();
            Random random = new Random();
            ID = random.Next(1, 999999);
        }

        public Client(string name, string surname, DateTime birthday) : base(name, surname, birthday)
        {
            Random random = new Random();
            ID = random.Next(1, 999999);
        }

        public Client(ObservableCollection<Order> orders, string name, string surname, DateTime birthday) : base(name, surname, birthday)
        {
            Random random = new Random();
            ID = random.Next(1, 999999);
            Orders = orders;
        }

        public int CountOrders() => Orders.Count;

        public bool IsOneDisount() => (CountOrders() > 5) ? true : false;

        public bool IsRegular() => (priceAllOrders > highPrice) ? true : false;
    }
}
