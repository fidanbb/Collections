using AccountProductTask.Models;
using AccountProductTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProductTask.Services
{
    public class AccountService : IAccountService
    {
        public List<User> GetAll()
        {
           List<User> users = new List<User>();

            users.Add(new User() { Id = 1,Email="fidan@gmail.com",Password="fidan123"});
            users.Add(new User() { Id = 2, Email = "nigar@gmail.com", Password = "nigar123" });
            users.Add(new User() { Id = 3, Email = "ehed@gmail.com", Password = "ehed123" });
            users.Add(new User() { Id = 4, Email = "zeynab@gmail.com", Password = "zeynab123" });

            return users;
        }

      
    }
}
