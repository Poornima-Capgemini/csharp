using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFCalcServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalcService" in both code and config file together.
    [ServiceContract]
    public interface ICalcService
    {

        [OperationContract]
        int Sum(int x, int y);
        [OperationContract]
        int Sub(int x, int y);
        [OperationContract]
        int Mult(int x, int y);

    }


    
}
