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
    public class Kernel
    {
        private double kernelPrice;

        public Material Material { get; set; }
        public double KernelPrice
        {
            get => kernelPrice;
            set
            {
                kernelPrice += Material.GrammPrice * Material.Weight;
            }
        }

        public Kernel()
        {
            Material = new Material();
        }

        public Kernel(Material m)
        {
            Material = m;
            KernelPrice = 0;
        }
    }
}
