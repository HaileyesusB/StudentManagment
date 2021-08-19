using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
   public  class CourseEntity : BaseEntity<Course>
    {

        public string Code { get; set; }
        public string Location { get; set; }
    
        public CourseEntity()
        {
           
        }
        public CourseEntity(Course course)
        {
            Code = course.Code;
            Location = course.Location;
        }

        public override Course MapToModel()
        {
            Course course = new Course();
            course.Location = Location;
            course.Code = Code;

            return course;
        }

        public override Course MapToModel(Course t)
        {
            throw new NotImplementedException();
        }
    }

}

