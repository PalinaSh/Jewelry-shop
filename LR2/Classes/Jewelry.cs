using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR2.Classes
{
    [Serializable]
    [XmlInclude(typeof(TypeOfJewerly))]
    [XmlInclude(typeof(List<Kernel>))]
    [XmlInclude(typeof(List<Basis>))]
    public class Jewelry
    {
        public string Name { get; set; }
        public string VenderCode { get; set; }
        public TypeOfJewerly Type { get; set; }
        public Kernel Kernel { get; set; }
        public Basis Basis { get; set; }
        private double jewelryPrice;
        public double JewelryPrice
        {
            get { return jewelryPrice; }
            set
            {
                    jewelryPrice += Kernel.KernelPrice;
                    jewelryPrice += Basis.BasisPrice;
            }
        }
        public string Brand { get; set; }
        public double Complexity { get; set; }
        public string Image { get; set; }
        //public List<double> Sizes { get; set; }
        public double NeedSize { get; set; }
        //public string Status { get; set; }

        public Jewelry()
        {
            Name = "";
            VenderCode = "";
            Type = new TypeOfJewerly();
            Kernel = new Kernel();
            Basis = new Basis();
            Brand = "";
            Image = "";
        }

        public Jewelry(string vc, TypeOfJewerly type, Kernel k, Basis b, string brand, double c, string im)
        {
            VenderCode = vc;
            Type = type;
            Kernel = k;
            Basis = b;
            Brand = brand;
            Complexity = c;
            Image = im;
            JewelryPrice = 0;
        }
    }
}
