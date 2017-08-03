namespace TrainDiary.Models.Calendar
{
    using System.Collections.Generic;
    using System;
    using TrainDiary.Models.Base;
    using TrainDiary.Models.Excercise;
    public class Day: BaseModel
    {
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public List<Excercise> Excercises { get; set; }
    }
}
