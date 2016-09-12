using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Index(IsUnique=true)]
        [StringLength(70)]
        public string Email { get; set; }
        [StringLength(70)]
        public string Firstname { get; set; }
        [StringLength(70)]
        public string Lastname { get; set; }
        [StringLength(70)]
        public string Country { get; set; }
        [StringLength(70)]
        public string City { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(30)]
        public string Postcode { get; set; }
    }
}
