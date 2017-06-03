using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InTouch_API.Models
{
    public class UserGroupUniversity
    {
        public Users User { get; set; }
        public Groups Group { get; set; }
        public Universities University { get; set; }
        public ICollection<SubjectsLearn> SubjectsInLearn { get; internal set; }
        public ICollection<Tests> AllTests { get; internal set; }
        public ICollection<Passed_tests> Passed_tests { get; internal set; }
    }
}