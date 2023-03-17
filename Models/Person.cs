using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_firstproject.Models
{
    public class Person
    {
        [Key]

        public int PersonId { get; set; }

        [Required]

        [StringLength(30)]

        [DisplayName("First Name")]

        public string FirstName { get; set; }

        [Required]

        [StringLength(30)]

        [DisplayName("Last Name")]

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [StringLength(18)]

        public string PersonalNumber { get; set; }

        public int Age { get; set; }
    }
}
