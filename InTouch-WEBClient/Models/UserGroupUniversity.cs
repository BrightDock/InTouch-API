using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InTouch_WEBClient
{
    public class UserGroupUniversity
    {
        public Users User { get; set; }
        public Groups Group { get; set; }
        public Universities University { get; set; }
        public SubjectsLearn Subjects { get; internal set; }
        public Passed_tests Tests { get; internal set; }
    }
}