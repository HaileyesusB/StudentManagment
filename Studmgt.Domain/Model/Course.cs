using Studmgt.Domain.Seeds;

namespace Studmgt.Domain.Model
{
    public class Course : BaseAuditableModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
