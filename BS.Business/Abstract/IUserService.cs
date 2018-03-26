using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Business.Abstract
{
    public interface IUserService
    {
        User Get(int? ID);
        User GetByUserName(string userName);
        ICollection<User> GetList();
        void Add(User entity);
        void Update(User entity);
        void Delete(User entity);
   


    }
}
