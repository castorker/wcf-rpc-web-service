using Client.RPC.RPCService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.RPC.DataServices
{
    class QuibbleDataService
    {
        private ServiceClient _client;

        public QuibbleDataService()
        {
            _client = new ServiceClient();
        }

        public Quibble[] GetAll()
        {
            return _client.GetAll();
        }

        public Quibble GetById(int id)
        {
            return _client.GetById(id);
        }

        public void Create(Quibble quibble)
        {
            _client.Create(quibble);
        }

        public void Update(Quibble quibble)
        {
            _client.Update(quibble);
        }

        public void Delete(int id)
        {
            _client.Delete(id);
        }
    }
}
