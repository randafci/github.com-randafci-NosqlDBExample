using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSqlDataBaseExample.BDSetting
{
    public class UserService: IUserService
    {
        private readonly Isetting<User> _isetting;
        public UserService(  Isetting<User> isetting)
        {
            _isetting = isetting;
        }
        public bool AddUser(User model)
        {

            _isetting.Add(model,"User");
            return true;
        }

        public List< User> GetUser()
        {

           var list= _isetting.GetAll("User");
            return list;
        }

    }
}
