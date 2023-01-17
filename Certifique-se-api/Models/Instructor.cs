using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certifique_se_api.Models
{
    public class instructor
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public Course CourseName { get; set; }
        public ICollection<PresenceList> PresenceList { get; set; }
    }
}
