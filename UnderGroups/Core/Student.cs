namespace UnderGroups.Core
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public ICollection<StudentGroup> StudentGroups { get; set; }
        public ICollection<LearningGroup> LearningGroups { get; set; }

        public ICollection<UnderGroup> UnderGroups { get; set; }
    }
}
