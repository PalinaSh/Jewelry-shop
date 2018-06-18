using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR2.Classes
{
    class ViewModel
    {
        public ObservableCollection<Jewelry> Jewelries { get; set; }
        public ObservableCollection<Jewelry> JewelryType { get; set; }
        Jewelry[] AllJewelries;
        Jewelry[] Rings;
        Jewelry[] Earrings;
        Jewelry[] Pendants;

        public ObservableCollection<Client> AllClients { get; set; }
        public ObservableCollection<Client> Clients { get; set; }

        public ObservableCollection<Master> AllMasters { get; set; }
        public ObservableCollection<Master> Masters { get; set; }

        public ObservableCollection<Order> AllOrders { get; set; }
        public ObservableCollection<Order> Orders { get; set; }

        public ViewModel()
        {
            JewelryRepairShop jrs = new JewelryRepairShop();
            //Jewelries = WorkWithFiles.DeserializeJewelry();
            Jewelries = jrs.Jewelries;

            //AllClients = WorkWithFiles.DeserializeClients();
            AllClients = jrs.Clients;
            Clients = new ObservableCollection<Client>();
            foreach (Client c in AllClients)
                Clients.Add(c);

            //AllMasters = WorkWithFiles.DeserializeMasters();
            AllMasters = jrs.Masters;
            Masters = new ObservableCollection<Master>();
            foreach (Master m in AllMasters)
                Masters.Add(m);

            JewelryType = new ObservableCollection<Jewelry>();
            GetCollections();

            AllOrders = new ObservableCollection<Order>();
            Orders = new ObservableCollection<Order>();
            GetOrders();
        }

        public void SaveChanges()
        {
            WorkWithFiles.SerializeJewelry(Jewelries);
            WorkWithFiles.SerializeClients(Clients);
            WorkWithFiles.SerializeMasters(Masters);
        }

        public void GetCollections()
        {
            Rings = Jewelries.Where(i => i.Type.NameOfJewerly == "кольцо").ToArray<Jewelry>();
            Earrings = Jewelries.Where(i => i.Type.NameOfJewerly == "серьги").ToArray<Jewelry>();
            Pendants = Jewelries.Where(i => i.Type.NameOfJewerly == "подвеска").ToArray<Jewelry>();
            AllJewelries = Jewelries.ToArray<Jewelry>();
        }

        public void GetOrders()
        {
            Orders.Clear();
            AllOrders.Clear();
            foreach (Client c in Clients)
                if (!(c.Orders is null))
                    foreach (Order o in c.Orders)
                    {
                        AllOrders.Add(o);
                        Orders.Add(o);
                    }
        }

        public Jewelry SomeJewelry { get; set; } = new Jewelry();
        public Client SomePerson { get; set; }
        public Client Client { get; set; } = new Client();
        public Master SomeMaster { get; set; } = new Master();
        public Order SomeOrder { get; set; }
        public DateTime Today { get; set; } = DateTime.Now;

        public void GetAllJewelry()
        {
            JewelryType.Clear();
            foreach (Jewelry j in AllJewelries)
                JewelryType.Add(j);
        }

        public void GetRings()
        {
            JewelryType.Clear();
            foreach (Jewelry j in Rings)
                JewelryType.Add(j);
        }

        public void GetEarrings()
        {
            JewelryType.Clear();
            foreach (Jewelry j in Earrings)
                JewelryType.Add(j);
        }

        public void GetPendant()
        {
            JewelryType.Clear();
            foreach (Jewelry j in Pendants)
                JewelryType.Add(j);
        }

        public void GetVenderCode(string vc)
        {            
            JewelryType.Clear();
            if (vc == "")
                GetAllJewelry();
            else
            {
                Jewelry[] j = AllJewelries.Where(i => i.VenderCode == vc).ToArray<Jewelry>();
                foreach (Jewelry i in j)
                    JewelryType.Add(i);
            }
        }

        public void GetSilver()
        {
            Jewelry[] selection = JewelryType.Where(i => i.Basis.Material.Name == "серебро").ToArray<Jewelry>();
            JewelryType.Clear();
            foreach (Jewelry j in selection)
            {
                JewelryType.Add(j);
            }
        }

        public void GetGold()
        {
            Jewelry[] selection = JewelryType.Where(i => i.Basis.Material.Name == "золото").ToArray<Jewelry>();
            JewelryType.Clear();
            foreach (Jewelry j in selection)
            {
                JewelryType.Add(j);
            }
        }

        public void GetCombine()
        {
            Jewelry[] selection = JewelryType.Where(i => i.Basis.Material.Name == "комбинированный").ToArray<Jewelry>();
            JewelryType.Clear();
            foreach (Jewelry j in selection)
            {
                JewelryType.Add(j);
            }
        }

        public void GetBrand(string brand)
        {
            Jewelry[] selection = JewelryType.Where(i => i.Brand == brand).ToArray<Jewelry>();
            JewelryType.Clear();
            foreach (Jewelry j in selection)
            {
                JewelryType.Add(j);
            }
        }

        public void GetKernel(string kernel)
        {
            Jewelry[] selection = JewelryType.Where(i => i.Kernel.Material.Name == kernel).ToArray<Jewelry>();
            JewelryType.Clear();
            foreach (Jewelry j in selection)
            {
                JewelryType.Add(j);
            }
        }

        public void GetSurname(string sn)
        {
            Clients.Clear();
            if (sn == "")
                GetAllPerson();
            else
            {
                Client[] cl = AllClients.Where(i => i.Surname == sn).ToArray<Client>();
                foreach (Client c in cl)
                    Clients.Add(c);
            }
        }

        public void GetID(string id)
        {
            //ObservableCollection<Jewelry> jewelries = new ObservableCollection<Jewelry>();
            //foreach()
            Clients.Clear();
            try
            {
                Client[] cl = AllClients.Where(i => i.ID == long.Parse(id)).ToArray<Client>();
                foreach (Client c in cl)
                    Clients.Add(c);
            }
            catch (FormatException e)
            {
                GetAllPerson();
            }
        }

        public void GetAllPerson()
        {
            Clients.Clear();
            foreach (Client c in AllClients)
                Clients.Add(c);
        }

        public void GetSurnameMaster(string sn)
        {
            Masters.Clear();
            if (sn == "")
                GetAllMasters();
            else
            {
                Master[] master = AllMasters.Where(i => i.Surname == sn).ToArray<Master>();
                foreach (Master m in master)
                    Masters.Add(m);
            }
        }

        public void GetRating(string r)
        {
            Masters.Clear();
            try
            { 
            Master[] master = AllMasters.Where(i => i.Rating == double.Parse(r)).ToArray<Master>();
            foreach (Master m in master)
                Masters.Add(m);
            }
            catch (FormatException e)
            {
                GetAllMasters();
            }
        }

        public void GetAllMasters()
        {
            Masters.Clear();
            foreach (Master m in AllMasters)
                Masters.Add(m);
        }

        public void GetAllOrders()
        {
            Orders.Clear();
            foreach (Order o in AllOrders)
                Orders.Add(o);
        }

        public void GetNameMasters(string name)
        {
            Orders.Clear();
            if (name == "")
                GetAllOrders();
            else
            {
                Order[] orders = AllOrders.Where(i => i.Master.Surname == name).ToArray<Order>();
                foreach (Order o in orders)
                    Orders.Add(o);
            }
        }

        public void GetCodeJewelry(string vc)
        {
            Orders.Clear();
            if (vc == "")
                GetAllOrders();
            else
            {
                Order[] orders = AllOrders.Where(i => i.Jewelry.VenderCode == vc).ToArray<Order>();
                foreach (Order o in orders)
                    Orders.Add(o);
            }
        }

        public void GetTypeJewelry(string type)
        {
            Orders.Clear();
            if (type == "")
                GetAllOrders();
            else
            {
                Order[] orders = AllOrders.Where(i => i.Jewelry.Type.NameOfJewerly == type).ToArray<Order>();
                foreach (Order o in orders)
                    Orders.Add(o);
            }
        }

        public void AddJewelry()
        {
            Jewelries.Add(SomeJewelry);
            GetCollections();
            if ((JewelryType.Count > 0 && SomeJewelry.Type.NameOfJewerly == JewelryType[0].Type.NameOfJewerly)
                || JewelryType.Equals(Jewelries))
                JewelryType.Add(SomeJewelry);
        }

        public void RemoveJewelry()
        {
            Jewelries.Remove(SomeJewelry);
            GetCollections();
            if ((JewelryType.Count > 0 &&  SomeJewelry.Type.NameOfJewerly == JewelryType[0].Type.NameOfJewerly)
                || JewelryType.Equals(Jewelries))
                JewelryType.Remove(SomeJewelry);    
        }
            
        public void RedactJewelry()
        {
            Jewelry jewelry = new Jewelry();
            jewelry = SomeJewelry;
            RemoveJewelry();
            Jewelries.Add(jewelry);
            GetCollections();
            if ((JewelryType.Count > 0 && jewelry.Type.NameOfJewerly == JewelryType[0].Type.NameOfJewerly)
                || JewelryType.Equals(Jewelries))
                JewelryType.Add(SomeJewelry);
        }

        public void AddJewelryInBasket()
        {
            for (int i = 0; i < Client.Basket.Count; ++i)
                if (Client.Basket[i].Equals(SomeJewelry))
                    return;
            Client.Basket.Add(SomeJewelry);
        }

        public void RemoveJewelryFromBasket()
        {
            for (int i = 0; i < Client.Basket.Count; ++i)
                if (Client.Basket[i] == SomeJewelry)
                { 
                    Client.Basket.RemoveAt(i);
                    JewelryType.Remove(SomeJewelry);
                    break;
                }
        }

        public void ShowBasket()
        {
            JewelryType.Clear();
            foreach (Jewelry j in Client.Basket)
                JewelryType.Add(j);
        }

        public void ShowCatalog()
        {
            JewelryType.Clear();
            foreach (Jewelry j in Jewelries)
                JewelryType.Add(j);
        }

        public void ShowOrders()
        {
            Orders.Clear();
            foreach (Order j in Client.Orders)
                Orders.Add(j);
        }

        public void RemoveOrder()
        {
            bool find = false;
            for (int i = 0; i < Clients.Count; ++i)
            { 
                foreach (Order o in Clients[i].Orders)
                {
                    if (o.Equals(SomeOrder))
                    {
                        Clients[i].Orders.Remove(o);
                        find = true;
                        break;
                    }
                }
                if (find)
                    break;
            }
            GetOrders();
        }

        public bool IsLogPass(string log, string passwd)
        {
            for (int i = 0; i < Clients.Count; ++i)
                if (Clients[i].Login == log && Clients[i].Password == passwd)
                {
                    Client = Clients[i];
                    return true;
                }
            return false;
        }

        public void AddClient()
        {
            AllClients.Add(SomePerson);
            Clients.Add(SomePerson);
            SaveChanges();
        }


        public void RemoveClient()
        {
            Clients.Remove(SomePerson);
            GetOrders();
            AllClients.Clear();
            foreach (Client c in Clients)
                AllClients.Add(c);
        }

        public void AddMaster()
        {
            AllMasters.Add(SomeMaster);
            Masters.Add(SomeMaster);
        }

        public bool RemoveMaster()
        {
            if (SomeMaster.Busy > 0)
                return false;
            AllMasters.Remove(SomeMaster);
            Masters.Clear();
            foreach (Master m in AllMasters)
                Masters.Add(m);
            return true;
        }

        public double GetPrice()
        {
            try { return SomeMaster.PriceHour * SomeJewelry.Complexity; }
            catch(NullReferenceException e) { return 0; }
        }

        public int GetEndWork()
        {
            try { return (SomeMaster.Rating > 0) ? (int)Math.Ceiling(SomeJewelry.Complexity / (0.1 * SomeMaster.Rating)) + 1 : 1; }
            catch(NullReferenceException e) { return 1; }
        }

        public void NewOrder()
        {
            int end = GetEndWork();
            Order order = new Order(SomeMaster, SomeJewelry, Today.AddDays(SomeMaster.Busy + 1),
                Today.AddDays(end + SomeMaster.Busy), "Заказ обрабатывается");
            for (int i = 0; i < Clients.Count; ++i)
                if (Clients[i].Equals(Client))
                {
                    Clients[i].Orders.Add(order);
                    Clients[i].Basket.Remove(SomeJewelry);
                    JewelryType.Remove(SomeJewelry);
                }
            for (int i = 0; i < Masters.Count; ++i)
                if (Masters[i].Equals(SomeMaster))
                    Masters[i].Busy += end;
            GetOrders();
            SaveChanges();
        }

        public double GetPriceOrder()
        {
            try { return (SomeMaster.PriceHour * SomeJewelry.Complexity + SomeJewelry.JewelryPrice)*(1-Client.RegularDiscount); }
            catch (NullReferenceException e) { return 0; }
        }

        public void GetNewDay()
        {
            Today = Today.AddDays(1);
            for (int i = 0; i < Clients.Count; ++i)
            {
                for (int j = 0; j < Clients[i].Orders.Count; ++j)
                {
                    if (Clients[i].Orders[j].End.Date == Today.Date)
                    {
                        AllOrders.Remove(Clients[i].Orders[j]);
                        Clients[i].Orders[j].Status = "Готово. Заберите заказ.";
                    }
                }
            }
            for(int i = 0; i < Masters.Count; ++i)
            {
                if (Masters[i].Busy > 0)
                {
                    Masters[i].Busy--;
                    AllMasters[i].Busy--;
                }
            }
        }
    }
}