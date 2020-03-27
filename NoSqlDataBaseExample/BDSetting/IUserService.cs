using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSqlDataBaseExample.BDSetting
{
    public  interface  IUserService
    {
         bool AddUser(User model);
        List<User> GetUser();
    }
}
