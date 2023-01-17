using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certifique_se_api.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<PresenceList> PresenceList { get; set; }
    }
}
