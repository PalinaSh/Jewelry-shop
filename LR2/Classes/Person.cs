using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(DateTime))]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private DateTime birthday;
        public DateTime Birthday
        {
            get => birthday.Date;
            set { birthday = value; }
        }

        public Person()
        {
            Birthday = DateTime.Today.Date;
        }

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday.Date;
        }
    }
}
