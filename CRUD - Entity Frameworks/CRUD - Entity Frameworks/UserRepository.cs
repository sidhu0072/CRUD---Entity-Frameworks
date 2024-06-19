using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Entity_Frameworks
{
    public class UserRepository
    {
        public List<User> ListAllUsers()
        {
            using (var context = new UserContext())
            {
                return context.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new UserContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new UserContext())
            {
                var existingUser = context.Users.Find(user.Id);
                if (existingUser != null)
                {
                    existingUser.Name = user.Name;
                    existingUser.Email = user.Email;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteUser(int userId)
        {
            using (var context = new UserContext())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }
    }

}
