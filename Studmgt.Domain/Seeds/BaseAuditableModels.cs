using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Seeds
{
    public abstract class BaseAuditableModels
    {
        public Guid Guid {protected set; get;}
   
        public Guid CreatedBy { set; get; }
        public DateTime CreatedDate { set; get; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
