using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(Material))]
    public class Basis
    {
        private double basisPrice;

        public Material Material { get; set; }
        public double BasisPrice
        {
            get => basisPrice;
            set
            {
                basisPrice = Material.GrammPrice * Material.Weight;
            }
        }

        public Basis()
        {
            Material = new Material();
        }

        public Basis(Material m)
        {
            Material = m;
            BasisPrice = 0;
        }
    }
}
