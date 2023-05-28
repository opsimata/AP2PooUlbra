using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPII.Domain.Entities;

namespace BankAPII.Domain.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        
    }
}