﻿namespace HeartSite
{
    public class User
    {

        private int? _age;

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
                    //todo: throw exception for showing error in swagger
                throw new Exception("Age must be greater than 18");         }

            }



        }
        public string? Job { get;set ; }
        public string? City { get; set; }
    }
}
