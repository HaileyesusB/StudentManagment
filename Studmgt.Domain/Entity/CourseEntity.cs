using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
   public abstract class studentEntity : BaseEntity<Student>
    {

        public string adress { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
    
        public studentEntity()
        {
           
        }
        public studentEntity(Student studentModel)
        {
            adress = studentModel.Adress;
            department = studentModel.Department;
            age = studentModel.Age;
            sex = studentModel.Sex;
        }

        public override Student MapToModel()
        {
            Student studModel = new Student();
            studModel.Adress = adress;
            studModel.Age = age;
            studModel.Department = department;
            studModel.Sex = sex;

            return studModel;
        }

        public override Student MapToModel(Student t)
        {
            throw new NotImplementedException();
        }
    }

}

