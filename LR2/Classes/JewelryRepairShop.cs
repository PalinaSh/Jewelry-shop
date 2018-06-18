using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2.Classes
{
    class JewelryRepairShop
    {
        public ObservableCollection<Jewelry> Jewelries { get; set; }

        public ObservableCollection<Client> Clients { get; set; }

        public ObservableCollection<Master> Masters { get; set; }

        public JewelryRepairShop()
        {
            Jewelries = WorkWithFiles.DeserializeJewelry();
            Clients = WorkWithFiles.DeserializeClients();
            Masters = WorkWithFiles.DeserializeMasters();
        }
    }
}
