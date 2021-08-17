using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Entity
{
   public class studentEntity: BaseAuditableEntity
    {

        public string adress { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public string sex { get; set; }

       
        public studentEntity()
        {
           
        }
        public studentEntity(studentModel studentModel)
        {
            adress = studentModel.adress;
            department = studentModel.department;
            age = studentModel.age;
            sex = studentModel.sex;
        }

        public override studentModel MapToModel()
        {
            studentModel studModel = new studentModel();
            studModel.adress = adress;
            studModel.age = age;
            studModel.department = department;
            studModel.sex = sex;
           
            return studModel;
        }

        public override studentModel MapToModel(studentModel t)
        {
            throw new NotImplementedException();
        }
    }

}
}
