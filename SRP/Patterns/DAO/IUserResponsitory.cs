using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Patterns.DAO
{
    public interface IUserResponsitory
    {
        User Get(int id);
        void Add(User user);
        void Update(User user);
        void Remove(User user);
    }

    public class UserResponsitory : IUserResponsitory
    {
        private readonly IUserDao _userDao;

        public UserResponsitory(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public void Add(User user)
        {
            _userDao.Create(user);
        }

        public User Get(int id)
        {
            return _userDao.Read(id);
        }

        public void Remove(User user)
        {
            _userDao.Delete(user.Name);
        }

        public void Update(User user)
        {
            _userDao.Update(user);
        }
    }
}
