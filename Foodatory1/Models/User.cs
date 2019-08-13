using System;
namespace Foodatory1.Models
{
    public class User
    {

        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User()
        {
        }

        public User(int id, string username, string email, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
