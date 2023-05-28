using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPII.Domain.Entities;
using BankAPII.Domain.Interfaces;
using Data;

namespace BankAPII.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext context;
        public ClientRepository(DataContext context)
        {
            this.context = context;
        }
        public bool Delete(int entityId)
        {
            bool validator;
            var client = GetById(entityId);
            if (client.Id == entityId)
            {
                context.Remove(client);
                context.SaveChanges();
                validator = true;
                Console.WriteLine($"\n{client.Name} data was successfully deleted from the database!\n");

            }
            else
            {
                validator = false;
                Console.WriteLine("\nInvalid Operation!");
            }
            return validator;
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