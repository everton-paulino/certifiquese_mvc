﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certifique_se_api.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFuntion { get; set; }
        public ICollection<Customer> PresenceList { get; set; }
    }
}
