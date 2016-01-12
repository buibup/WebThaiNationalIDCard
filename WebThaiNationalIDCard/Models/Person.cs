using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebThaiNationalIDCard.Models
{
    public class Person
    {
        public string id { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public string Th_Prefix { get; set; }
        public string Th_Firstname { get; set; }
        public string Th_Lastname { get; set; }
    }
}