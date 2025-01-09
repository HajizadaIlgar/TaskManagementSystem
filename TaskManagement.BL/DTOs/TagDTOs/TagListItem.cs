namespace TaskManagement.BL.DTOs.TagDTOs
{
    public class TagListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Urgent { get; set; }
        public string UntilTomorrow { get; set; }
        public string ItIsNotImportant { get; set; }
    }
}
