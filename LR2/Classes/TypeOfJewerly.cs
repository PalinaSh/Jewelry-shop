using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(List<double>))]
    public class TypeOfJewerly
    {
        public string NameOfJewerly { get; set; }
        public double JewerlyPrice { get; set; }
        public string Information { get; set; }

        public TypeOfJewerly()
        {
            NameOfJewerly = "";
            Information = "";
        }

        public TypeOfJewerly(string n, double jp, string info)
        {
            NameOfJewerly = n;
            JewerlyPrice = jp;
            Information = info;
        }
    }
}
