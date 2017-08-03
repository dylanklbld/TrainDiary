namespace TrainDiary.Models.Workout
{
    using TrainDiary.Enums.Workout;
    using TrainDiary.Models.Base;
    public class BodyPart: BaseModel
    {
        public string Info { get; set; }

        public int ImpactLevel { get; set; }

        public TypeBodyPart TargetPart { get; set; }
    }
}
