using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Patterns.DAO
{
    public interface IUserDao
    {
        void Create(User user);
        User Read(int id);
        void Update(User user);
        void Delete(string userName);
    }

    public class UserDao : IUserDao
    {
        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(string userName)
        {
            throw new NotImplementedException();
        }

        public User Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
