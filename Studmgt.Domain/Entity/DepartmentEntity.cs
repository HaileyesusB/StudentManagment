using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;

namespace Studmgt.Domain.Entity
{
    public class DepartmentEntity : BaseEntity<Department>
    {


        public DepartmentEntity()
        {
                
        }
        public DepartmentEntity(Department department)
        {

        }
        public override Department MapToModel()
        {
            throw new NotImplementedException();
        }

        public override Department MapToModel(Department t)
        {
            throw new NotImplementedException();
        }
    }
}
