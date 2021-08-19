using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
  public  class CourseEntity: BaseEntity<Course>
    {
        //public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        //public string Description { get; set; }

        public override Course MapToModel()
        {
            Course course = new Course();
            course.Code = Code;
            course.Location = Location;
            return course;
        }

        public override Course MapToModel(Course t)
        {
            t.Code = Code;
            t.Location = Location;
            return t;
        }
    }
}
