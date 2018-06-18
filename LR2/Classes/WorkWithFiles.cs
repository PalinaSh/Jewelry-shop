using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    static class WorkWithFiles
    {
        public static void SerializeJewelry(ObservableCollection<Jewelry> jewelries)
        { 
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Jewelry>));
            using (FileStream fs = new FileStream("Jewelries.xml", FileMode.Create))
            {
                formatter.Serialize(fs, jewelries);
            }
        }

        public static ObservableCollection<Jewelry> DeserializeJewelry()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Jewelry>));
            ObservableCollection<Jewelry> jewelries;
            using (FileStream fs = new FileStream("Jewelries.xml", FileMode.OpenOrCreate))
            {
                jewelries = (ObservableCollection<Jewelry>)formatter.Deserialize(fs);
            }
            return jewelries;
        }

        public static void SerializeClients(ObservableCollection<Client> clients)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Client>));
            using (FileStream fs = new FileStream("Clients.xml", FileMode.Create))
            {
                formatter.Serialize(fs, clients);
            }
        }

        public static ObservableCollection<Client> DeserializeClients()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Client>));
            ObservableCollection<Client> clients;
            using (FileStream fs = new FileStream("Clients.xml", FileMode.OpenOrCreate))
            {
                clients = (ObservableCollection<Client>)formatter.Deserialize(fs);
            }
            return clients;
        }

        public static void SerializeMasters(ObservableCollection<Master> masters)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Master>));
            using (FileStream fs = new FileStream("Masters.xml", FileMode.Create))
            {
                formatter.Serialize(fs, masters);
            }
        }

        public static ObservableCollection<Master> DeserializeMasters()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Master>));
            ObservableCollection<Master> masters;
            using (FileStream fs = new FileStream("Masters.xml", FileMode.OpenOrCreate))
            {
                masters = (ObservableCollection<Master>)formatter.Deserialize(fs);
            }
            return masters;
        }
    }

}
