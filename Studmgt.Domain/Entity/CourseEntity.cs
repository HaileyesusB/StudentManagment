using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using Studmgt.Domain.Model;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
    public abstract class CourseEntity : BaseEntity<Course>
    //public abstract class CourseEntity : BaseEntity<Course>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CourseEntity()
        {


        }


    }
}
