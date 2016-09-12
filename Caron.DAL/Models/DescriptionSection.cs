using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class DescriptionSection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DescriptionId { get; set; }
        [StringLength(800)]
        public string DescriptionBody { get; set; }
        [StringLength(70)]
        public string DescriptionTitle { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
