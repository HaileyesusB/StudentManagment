using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Seeds
{
   public abstract class BaseEntity <T> where T: BaseAuditableEntity
    {

        public virtual Guid Guid { get; set; }

        public string _name{ get; set; }

        public string _description { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedbyUserGuid { get; set; }
        public Guid? LastModifiedByUserGuid { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
    }
}
