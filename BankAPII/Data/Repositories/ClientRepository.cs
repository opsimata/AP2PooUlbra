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
            return context.Clients.ToList();
        }

        public Client GetById(int entityId)
        {
            return context.Clients.SingleOrDefault(x => x.Id == entityId); // === Select All From *People* Where ID == Parsed ID.
        }

        public void Save(Client entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Client entity)
        {
            context.Clients.Update(entity);
            context.SaveChanges();
        }
    }
}