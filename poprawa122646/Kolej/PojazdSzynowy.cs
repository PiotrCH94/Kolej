using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolej
{
    abstract class PojazdSzynowy
    {
        protected string marka;
        protected int masa;

        public PojazdSzynowy(string marka,int masa)
        {
            this.marka = marka;
            this.masa = masa;
        }
        public abstract double ObliczKoszt(double koszt)
        {
            return koszt;
        }
        public abstract string Info();
 
    }
}
