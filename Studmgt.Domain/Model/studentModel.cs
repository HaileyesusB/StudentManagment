using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Model
{
   public class studentModel: BaseAuditableEntity
    {
     
        public  string adress { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public studentModel()
        {

        }
    }
}
