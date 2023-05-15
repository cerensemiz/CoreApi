using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels
{
    public class StudentVM
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } 

        public string? FirstName { get; set; }
        public string? SecondName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
