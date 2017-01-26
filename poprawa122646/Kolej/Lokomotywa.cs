using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolej
{
    class Lokomotywa:PojazdSzynowy
    {
        public override double ObliczKoszt(double koszt)
        {
            return koszt = masa * 34;
        }
        public override string Info()
        {
            string outPut;
            outPut = "Lokomotywa, model: " + marka + ", masa: " + masa;
            return outPut;
        }
    }
}
