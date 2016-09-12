using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReserationId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte NumberOfPeople { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        public int CreatedById{ get; set; }
        public Boolean HasPaid { get; set; }
        [ForeignKey("CreatedById")]
        public virtual User CreatedBy { get; set; }
        public virtual ICollection<ReservationPeriod> ReservationPeriods { get; set; }
       
    }
}
