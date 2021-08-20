
using Studmgt.Domain.Seeds;

namespace Studmgt.Domain.Model
{
    public class Department: BaseAuditableModels
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
