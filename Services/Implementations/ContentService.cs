using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Interfaces;
using DomainCore.Models;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ContentService : IContentService
    {
        private IGenericRepository<Content> contentRepository;
        private IGenericRepository<Domain> domainRepository;
        public ContentService(IGenericRepository<Content> contntRepository, IGenericRepository<Domain> domainRepository)
        {
            this.contentRepository = contntRepository;
            this.domainRepository = domainRepository;
        }

        public int CreateContent(Content content,string domainName)
        {
            var domain = domainRepository.Get(d=>d.Name.Equals(domainName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

            content.Domain = domain;

            contentRepository.Insert(content);
            return contentRepository.SaveChanges();
        }

        public int CreateContent(string contentName, string domainName)
        {
            Content content = new Content { Name = "conetent", ContentType = ContentType.Folder };

            return CreateContent(content, domainName);
        }

        public Content GetContent(int id)
        {
            return contentRepository.Get(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Content> GetContents()
        {
            return contentRepository.Get( includeProperties: "Domain").ToList();
        }
    }
}
