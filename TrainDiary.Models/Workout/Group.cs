namespace TrainDiary.Models.Workout
{
    using TrainDiary.Models.Base;

    public class Group:BaseModel
    {
        public string Info { get; set; }

        public TypeMuscleGroup TargetGroup { get; set; }

    }
}
