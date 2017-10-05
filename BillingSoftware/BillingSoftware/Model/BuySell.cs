using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware.Model
{
    class BuySell
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String Type { get; set; }
    }
}
