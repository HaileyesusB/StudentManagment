using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
   
   public  class studentEntity : BaseEntity<Student>
    {

        public string Adress { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    
        public studentEntity()
        {
           
        }
        public studentEntity(Student studentModel)
        {
            Adress = studentModel.Adress;
            Department = studentModel.Department;
            Age = studentModel.Age;
            Sex = studentModel.Sex;
        }

        public override Student MapToModel()
        {
            Student studModel = new Student();
            studModel.Adress = Adress;
            studModel.Age = Age;
            studModel.Department = Department;
            studModel.Sex = Sex;

            return studModel;
        }

        public override Student MapToModel(Student t)
        {
            throw new NotImplementedException();
        }
    }

}

