using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class HighLightCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HighLightCategoryId { get; set; }
        [StringLength(70)]
        public string Label { get; set; }
    }
}
