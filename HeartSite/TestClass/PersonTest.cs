namespace HeartSite.TestClass
{
    public class PersonTest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CommentTest> CommentsTests { get; set; }
    }
}
