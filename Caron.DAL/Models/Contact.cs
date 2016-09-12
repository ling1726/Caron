using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        public int ContactSubjectId { get; set; }
        [ForeignKey("ContactSubjectId")]
        public ContactSubject ContactSubject { get; set; }
        
    }
}
