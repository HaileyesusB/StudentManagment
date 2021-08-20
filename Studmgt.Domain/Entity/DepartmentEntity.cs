using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;

namespace Studmgt.Domain.Entity
{
    public  class DepartmentEntity : BaseEntity<Department>
    {
        //public string Name { get; set; }
        public string Location { get; set; }
        //public string Description { get; set; }
        public DepartmentEntity()
        {
         
        }
        public DepartmentEntity(Department department)
        {
            Location = department.Location;

        }
        public override Department MapToModel()
        {
            Department department = new Department();
            department.Location = Location;

            return department;
        }
        public override Department MapToModel(Department t)
        {
            Department department = t;
           
            department.Location = Location;
            return department;
        }
    }
}
