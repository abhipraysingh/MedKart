using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedKart.Models
{
    public class MedicineType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Medicine Type")]
        public string Name { get; set; }
    }
}
