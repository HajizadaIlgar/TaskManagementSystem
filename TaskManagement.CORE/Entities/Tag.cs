using System.ComponentModel.Design;
using TaskManagementSystem.Entities.Commons;

namespace TaskManagementSystem.Entities
{
    public class Tag:BaseEntity
    {
       public string Name {  get; set; }
        public string Urgent { get; set; }
        public string UntilTomorrow { get; set; }
        public string ItIsNotImportant { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
