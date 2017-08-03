using System;
using System.Collections.Generic;
using System.Text;

namespace TrainDiary.Controllers.Auth
{
    using Microsoft.AspNetCore.Mvc;

    [Route("Login")]
    public class LoginController: Controller
    {
        [Route("Login/Test")]
        public void Test(string name, string password)
        {
            string username = name;
            string pass = password;
        }
    }
}
