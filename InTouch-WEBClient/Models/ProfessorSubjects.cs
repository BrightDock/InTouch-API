﻿using System.Collections.Generic;

namespace InTouch_WEBClient.Models
{
    public class ProfessorSubjects
    {
        public Users Professor { get; set; }
        public Universities University { get; set; }
        public IEnumerable<Subjecst_professors> Subjects { get; set; }
    }
}