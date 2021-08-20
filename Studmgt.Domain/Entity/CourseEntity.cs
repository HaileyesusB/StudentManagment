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
        
    
        public CourseEntity()
        {
           
        }
        public CourseEntity(Course course)
        {
            Code = course.Code;
            
        }

        public override Course MapToModel()
        {
            Course course = new Course();
            course.Code = Code;

            return course;
        }

        public override Course MapToModel(Course t)
        {
            Course course = t;

            course.Code = Code;
            return course;
        }
    }

}

