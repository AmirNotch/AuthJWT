using System.Collections.Generic;

namespace AuthJWT.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                UserName = "jason_admin", 
                EmailAddress = "jason.admin@email.com", 
                Password = "My_password",
                GivenName = "Jason", 
                SurName = "Bryant", 
                Role = "Administrator"
            },
            new UserModel()
            {
                UserName = "elise_seller", 
                EmailAddress = "elise.sellar@email.com", 
                Password = "My_password",
                GivenName = "Elise", 
                SurName = "Lambert", 
                Role = "Seller"
            }
        };
    }
}