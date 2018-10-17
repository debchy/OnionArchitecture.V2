using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Models
{
    public class Domain
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //public IEnumerable<Folder> Folders { get; set; }
        public IEnumerable<Content> Contents { get; set; }

    }
}
