namespace HeartSite.TestClass
{
    public class CommentTest
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

