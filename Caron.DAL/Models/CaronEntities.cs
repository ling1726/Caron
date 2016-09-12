using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.Models
{
    public class CaronEntities : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationPeriod> ReservationPeriods { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<DescriptionSection> DescriptionSections { get; set; }
        public DbSet<ContactSubject> ContactSubjects { get; set; }
        public DbSet<Highlight> Highlights { get; set; }
        public DbSet<HighLightCategory> HighlightCategories { get; set; }
    }
}
