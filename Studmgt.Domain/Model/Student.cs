using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Model
{
   public class Student: BaseAuditableModels
    {
        public  string Adress { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Student()
        {

        }
    }
}
