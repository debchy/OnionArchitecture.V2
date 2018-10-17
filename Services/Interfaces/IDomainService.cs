using DomainCore.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    
    public interface IDomainService
    {
        IEnumerable<Domain> GetDomains();
        void InsertDomain(Domain domain);
    }
}
