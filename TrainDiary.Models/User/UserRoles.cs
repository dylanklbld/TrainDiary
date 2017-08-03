using TrainDiary.Models.Base;

namespace TrainDiary.Models.User
{
    using TrainDiary.Enums.User;
    using TrainDiary.Enums.Workout;
    public class UserRoles : BaseModel
    {
        public virtual User User { get; set; }
        public virtual string Name { get; set; }
        public virtual RoleType Role { get; set; }

    }
}