namespace TaskManagementSystem.Entities.Commons;
public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime DeedLine { get; set; }
    public bool IsDeleted { get; set; }
}
