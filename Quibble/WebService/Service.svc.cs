using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private QuibbleDataService _service;

        public Service()
        {
            _service = new QuibbleDataService();
        }

        public Quibble[] GetAll()
        {
            return _service.GetAll();
        }

        public Quibble GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Create(Quibble quibble)
        {
            _service.Add(quibble);
        }

        public void Update(Quibble quibble)
        {
            _service.Update(quibble);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
