using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.ViewModels.Contact
{
    public class ContactViewModel
    {
        public int ContactId { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int ContactSubjectId { get; set; }
    }
}
