using System;
using System.Collections.Generic;
using System.Text;
using TrainDiary.Models.Base;

namespace TrainDiary.Models.User
{
    public class User : BaseModel
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public IList<UserRoles> Roles { get; set; }
    }
}
