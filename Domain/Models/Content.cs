using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StoredFileName { get; set; }

        public int? MediaTypeId { get; set; }        

        public int DomainId { get; set; }
        public virtual Domain Domain { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsPublic { get; set; }
        public int OwnerId { get; set; }

        public bool IsDeleted { get; set; }
        public int? ParentContentId { get; set; }
        public virtual Content ParentContent { get; set; }

    }

    public enum ContentType { File = 1, Folder=2 };
}
