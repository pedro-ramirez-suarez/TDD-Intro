using System;
namespace Calculator.BL
{
    public interface ISimpleCalculator
    {
        decimal Division(decimal dividendo, decimal divisor);
        decimal Multiplicacion(decimal multiplicando, decimal multiplicador);
        decimal Resta(decimal minuendo, decimal substraendo);
        decimal Suma(decimal sumando1, decimal sumando2);
    }
}
