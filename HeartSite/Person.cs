namespace HeartSite
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
