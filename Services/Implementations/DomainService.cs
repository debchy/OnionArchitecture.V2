using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;
using Services.Interfaces;

namespace Services.Implementations
{
    public class DomainService : IDomainService
    {
        public IEnumerable<Domain> GetDomains()
        {
            throw new NotImplementedException();
        }

        public void InsertDomain(Domain domain)
        {
            throw new NotImplementedException();
        }
    }
}
