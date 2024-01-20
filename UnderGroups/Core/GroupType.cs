namespace UnderGroups.Core
{
    public class GroupType
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public ICollection<UnderGroup> UnderGroups { get; set; }
    }
}
