using DomainCore.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IContentService
    {
        IEnumerable<Content> GetContents();
        Content GetContent(int id);
        int CreateContent(Content content, string domainName);
        int CreateContent(string contentName, string domainName);
    }
}
