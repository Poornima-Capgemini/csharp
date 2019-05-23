using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEmpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployService" in both code and config file together.
    [ServiceContract]
    public interface IEmployService
    {
        [OperationContract]
        bool UpdateEmp(Emp objEmp);
        [OperationContract]
        int AutoGenerateEmpno();
        [OperationContract]
        bool InsertEmp(Emp objEmp);
        [OperationContract]
        List<Emp> ShowEmp();
        [OperationContract]
        Emp SearchEmp(int empno);
    }

    [DataContract]
    public class Emp
    {
        [DataMember]
        public int Empno { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Dept { get; set; }
        [DataMember]
        public string Desig { get; set; }
        [DataMember]
        public int Basic { get; set; }


    }


}
