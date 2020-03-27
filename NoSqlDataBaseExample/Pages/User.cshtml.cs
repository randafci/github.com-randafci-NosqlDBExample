using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NoSqlDataBaseExample.BDSetting;
namespace NoSqlDataBaseExample
{
    public class UserModel : PageModel
    {
        private readonly IUserService _userService;
        public UserModel(IUserService userService)
        {
            _userService = userService;
        }
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
         public List<User>user
        {
            get;
            set;
        }
        public void OnGet()
        {
             user = _userService.GetUser();
        }

        public void OnPost()
        {
            var user = new User()
            {
                Email = Request.Form[nameof(Email)],
            Name = Request.Form[nameof(Name)]
            };
            var x = _userService.AddUser(user);
        }
    }
}