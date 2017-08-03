using System;
using System.Collections.Generic;
using System.Text;

namespace TrainDiary.Services.User
{
    public interface IUserContext
    {
        long UserId { get; set; }
    }
}
