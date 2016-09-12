using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class Highlight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HighLightId { get; set; }
        [StringLength(70)]
        public string Label { get; set; }
        public int HighLightCategoryId { get; set; }
        [ForeignKey("HighLightCategoryId")]
        public virtual HighLightCategory HightLightCategory { get; set; }
    }
}
