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
    }
}