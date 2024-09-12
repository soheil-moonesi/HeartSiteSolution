namespace HeartSite
{
    public class Comment
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
    }
}
