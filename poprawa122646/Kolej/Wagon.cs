using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolej
{
    class Wagon:PojazdSzynowy
    {
        private double ladunek;

        public override double ObliczKoszt()
        {
            if (ladunek != 0)
            {
                ladunek = 3000 + masa;
            }
            else 
            {
                ladunek = 3000;
            }
            throw new NotImplementedException();
        }
        public override string Info()
        {
            return "Wagon, model " + marka + ", masa: " + masa;
        }

    }
}
