using System;
using TrainDiary.Services.User;

namespace TrainDiary.Services
{
    public class UserContext : IUserContext
    {
        public long UserId { get; set; }
    }
}
