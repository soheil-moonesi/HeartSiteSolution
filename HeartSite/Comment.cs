namespace HeartSite
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // Foreign Key Property
        public int PersonId { get; set; }

        // Navigation Property
        public Person Person { get; set; }

        public Category Category { get; set; }
        public int CategoryIndicator { get; set; }
    }
}
