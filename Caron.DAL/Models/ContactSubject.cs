using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class ContactSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactSubjectId { get; set; }
        [StringLength(70)]
        [Index(IsUnique = true)]
        public string Label { get; set; }
    }
}
