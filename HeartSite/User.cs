namespace HeartSite
{
    public class User
    {

        //todo: add Client info to List for using in next part of application
        private int? _age;

        public string Name { get; set; }
        public int? Age
        {
            get { return _age;}
            set
            {
                if (Age > 18)
                {
                    _age = value;
                }
                else
                { 
                    //todo: throw exception for showing error in swagger
                throw new Exception("Age must be greater than 18");         }

            }



        }
        public string? Job { get;set ; }
        public string? City { get; set; }
    }
}
