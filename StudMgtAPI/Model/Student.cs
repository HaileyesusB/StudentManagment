using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudMgtAPI.Model
{
    public class Student
    {
        public int Guid {  set; get; }
        public string name { set; get; }

        public string department { set; get; }

        public int age { set; get; }
        public string sex { set; get; }
        public string adress { set; get; }
       // public string department { set; get; }
    }
}
