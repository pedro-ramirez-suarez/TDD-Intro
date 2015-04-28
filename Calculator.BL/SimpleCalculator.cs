using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BL
{
    public class SimpleCalculator : Calculator.BL.ISimpleCalculator
    {

        public decimal Suma(decimal sumando1, decimal sumando2)
        {
            return sumando1 + sumando2;
        }

        public decimal Resta(decimal minuendo, decimal substraendo)
        {
            return minuendo - substraendo;
        }

        public decimal Division (decimal dividendo, decimal divisor)
        {
            return dividendo / divisor;
        }

        public decimal Multiplicacion(decimal multiplicando, decimal multiplicador)
        {
            return multiplicando * multiplicador;
        }
    }
}
