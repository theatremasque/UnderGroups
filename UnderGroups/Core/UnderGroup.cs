namespace UnderGroups.Core
{
    public class UnderGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int GroupTypeId { get; set; }
        public int StudentId { get; set; }
        public string Title { get; set; } = null!;

        public Group Group { get; set; }
        public GroupType GroupType { get; set; }
        public Student Student { get; set; }

        public ICollection<LearningGroup> LearningGroups { get; set; }
    }
}
