using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_firstproject.Models
{
    public class OrderList
    {
        [Key]

        public int Id { get; set; }
        public int FkPersonId { get; set; }
        public int FkProductId { get; set; }

    }
}
