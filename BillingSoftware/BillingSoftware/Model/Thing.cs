using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware.Model
{
    public class Thing
    {       
        [Required]
        public int Id { get; set; }

        [Key]
        [StringLength(50)]
        public String Name { get; set; }

        [Required]
        public int CountWeight { get; set; }

        [Required]
        public double BuyRate { get; set; }

        [Required]
        public double SellRate { get; set; }
    }
}
