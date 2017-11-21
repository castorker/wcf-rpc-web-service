using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Quibble[] GetAll();

        [OperationContract]
        Quibble GetById(int id);

        [OperationContract]
        void Create(Quibble quibble);

        [OperationContract]
        void Update(Quibble quibble);

        [OperationContract]
        void Delete(int id);
    }
}
