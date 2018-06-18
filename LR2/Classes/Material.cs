using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2.Classes
{
    [Serializable]
    public class Material
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double GrammPrice { get; set; }

        public Material()
        {
            Name = "";
        }
        
        public Material(string n, double w, double gp)
        {
            Name = n;
            Weight = w;
            GrammPrice = gp;
        }
    }
}
