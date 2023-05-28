using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPII.Domain.Entities;
using BankAPII.Domain.Interfaces;
using Data;

namespace BankAPII.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext context;

        public bool Delete(int entityId)
        {
            bool validator;
            var account = GetById(entityId);
            if (account.Id == entityId)
            {
                context.Remove(account);
                context.SaveChanges();
                validator = true;
                Console.WriteLine($"\nAccount corresponding to the ID:{account.Id} was successfully deleted from the database!\n");

            }
            else
            {
                validator = false;
                Console.WriteLine("\nInvalid Operation!");
            }
            return validator;
        }

        public IList<BankAccount> GetAll()
        {
            return context.Accounts.ToList();
        }

        public BankAccount GetById(int entityId)
        {
            return context.Accounts.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(BankAccount entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(BankAccount entity)
        {
            context.Accounts.Update(entity);
            context.SaveChanges();
        }
    }
}