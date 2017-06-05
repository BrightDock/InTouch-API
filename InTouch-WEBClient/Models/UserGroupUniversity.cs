using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InTouch_WEBClient.Models
{
    public class UserGroupUniversity
    {
        public Users User { get; set; }
        public Groups Group { get; set; }
        public Universities University { get; set; }
        public IEnumerable<Subjects_learn> SubjectsInLearn { get; set; }
        public IEnumerable<Tests> AllTests { get; set; }
        public IEnumerable<Passed_tests> Passed_tests { get; set; }
    }
}