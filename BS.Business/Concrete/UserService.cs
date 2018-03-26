using BS.Business.Abstract;
using BS.DataAccess.Abstract;
using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Business.Concrete
{
    public class UserService : IUserService
    {

        private IUserDAL _userDAL;

        public UserService(IUserDAL kisiDAL)
        {
            _userDAL = kisiDAL;
        }

        public void Add(User item)
        {
            _userDAL.Add(item);
        }

        public void Delete(User item)
        {
            _userDAL.Delete(item);
        }

        public User Get(int? ID)
        {
            return _userDAL.Get(e => e.ID == ID);
        }

        public Model.Entities.User GetByUserName(string userName)
        {
            return _userDAL.Get(e => e.UserName == userName);
        }

        public ICollection<User> GetList()
        {
            return _userDAL.GetList();
        }

        public void Update(User item)
        {
            _userDAL.Update(item);
        }



    }
}
