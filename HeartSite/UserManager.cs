using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace HeartSite
{
    public static class UserManager
    {
        public static List<User> users = new List<User>();
       
        public static void SeedData()
        {
            User user1 = new User
            {
               
                Name = "Soheil",
                Age = 30,
                comment = new List<Comment>()
                {
                    new Comment{Text="good"},
                    new Comment{Text="good for developer"}
                }
            };
            users.Add(user1);

            User user2 = new User
            {
                
                Name = "Sepehr",
                Age = 22,
                comment = new List<Comment>()
                {
                new Comment{Text="sport"},
            }
            };
            users.Add(user2);

        

        }
        public static int SearchIdByName(string name)
        {
            return users.FindIndex(x => x.Name == name);
        }
    }
}
