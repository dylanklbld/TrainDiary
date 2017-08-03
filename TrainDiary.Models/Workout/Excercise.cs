namespace TrainDiary.Models.Excercise
{
    using System.Collections.Generic;
    using TrainDiary.Models.Base;
    using TrainDiary.Models.Workout;
    public class Excercise: BaseModel
    {
        public string Name { get; set; }

        public Group TargetGroup { get; set; }

        public List<BodyPart> ImpactedBodyparts { get; set; }

        public Routine Routine { get; set; }
    }
}
