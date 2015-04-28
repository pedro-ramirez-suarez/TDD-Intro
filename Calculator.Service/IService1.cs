using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        decimal Suma(decimal sumando1, decimal sumando2);
        
        [OperationContract]
        decimal Multiplicacion(decimal multiplicando, decimal multiplicador);
        
        [OperationContract]
        decimal Resta(decimal minuendo, decimal substraendo);

        [OperationContract]
        decimal Division(decimal dividendo, decimal divisor);
    }


    
}
