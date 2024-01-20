namespace UnderGroups.Core
{
    public class LearningGroup
    {
        public int UnderGroupId { get; set; }
        public int StudentId { get; set; }
        public UnderGroup UnderGroup { get; set; }
        public Student Student { get; set; }

        public ICollection<LearningGroup> LearningGroups { get; set; }
    }
}
