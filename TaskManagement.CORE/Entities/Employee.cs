using TaskManagementSystem.Entities.Commons;

namespace TaskManagementSystem.Entities
{
    public class Employee :BaseEntity
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        public DateTime BirthDay {  get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
