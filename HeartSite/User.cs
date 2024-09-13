
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HeartSite
{
    public class User
    {
        //todo: px structure for reply and comment
        //todo: px create separate User Client DTO and Server DTO

        private int _IdCounter;
        [BindNever]
        public int Id { get; private set; }

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

        public User() { 
            _IdCounter++;
            Id = _IdCounter++;
        }
    }
}
