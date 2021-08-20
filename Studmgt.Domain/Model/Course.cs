using Studmgt.Domain.Seeds;

namespace Studmgt.Domain.Model
{
    public class Course : BaseAuditableModels
    {
       
        public string Name { get; set; }
        public string Code { get; set; }
       
        public string Description { get; set; }
    }
}
