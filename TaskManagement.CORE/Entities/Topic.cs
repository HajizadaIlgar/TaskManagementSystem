using TaskManagementSystem.Entities.Commons;

namespace TaskManagementSystem.Entities
{
    public class Topic:BaseEntity
    {
        public string Name {  get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public int AssignmentId { get; set; }
    }
}
