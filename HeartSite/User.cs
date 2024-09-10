
namespace HeartSite
{
    public class User
    {
        //todo: p1 create new Schema for All class 
        //todo: p1-2 seed data for test
        public int Id { get; set; }
        private int? _age;
        internal List<Comment> comment;

        public string Name { get; set; }
        public int? Age
        {
            get { return _age;}
            set
            {
                if (value < 100)
                {
                    _age = value;
                }
                else
                { 
                    //todo: px throw exception for showing error in swagger
                throw new Exception("Age must be greater than 18");         }

            }



        }
        public string? Job { get;set ; }
        public string? City { get; set; }

        public ICollection<Comment> Comments { get; set; } 
    }
}
