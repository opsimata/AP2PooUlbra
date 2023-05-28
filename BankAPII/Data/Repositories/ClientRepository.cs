using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPII.Domain.Entities;
using BankAPII.Domain.Interfaces;

namespace BankAPII.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public IList<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public void Save(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}