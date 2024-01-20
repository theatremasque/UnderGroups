namespace UnderGroups.Core
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public ICollection<UnderGroup> UnderGroups { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
