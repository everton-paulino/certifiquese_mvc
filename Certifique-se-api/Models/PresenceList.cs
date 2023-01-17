using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certifique_se_api.Models
{
    public class PresenceList
    {
        public int PresenceListId { get; set; }
        public Course? CourseName { get; set; }
        public Customer? CustomerName { get; set; }
        public Customer? CustomerCnpj { get; set; }
        public instructor? InstructorName { get; set; }
        public Student? StudentName { get; set; }
        public Student? StudentFuntion { get; set; }


    }
}
