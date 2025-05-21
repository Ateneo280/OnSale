using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Common.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        [Display(Name = "Country Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
