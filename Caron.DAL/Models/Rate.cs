using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class Rate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NightlyRate { get; set; }
        [StringLength(70)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ReservationPeriod> RervationPeriods { get; set; }
    }
}
