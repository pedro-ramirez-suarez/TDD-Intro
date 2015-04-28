using Calculator.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        ISimpleCalculator calc;
        
        //default CTOR
        public Service1()
        {
            this.calc = new SimpleCalculator();
        }

        public Service1(ISimpleCalculator calculator)
        {
            this.calc = calculator;
        }

        public decimal Suma(decimal sumando1, decimal sumando2)
        {
            return calc.Suma(sumando1, sumando2);
        }

        public decimal Multiplicacion(decimal multiplicando, decimal multiplicador)
        {
            return calc.Multiplicacion(multiplicando, multiplicador);
        }

        public decimal Resta(decimal minuendo, decimal substraendo)
        {
            return calc.Resta(minuendo, substraendo);
        }

        public decimal Division(decimal dividendo, decimal divisor)
        {
            return calc.Division(dividendo, divisor);
        }

       
    }
}
