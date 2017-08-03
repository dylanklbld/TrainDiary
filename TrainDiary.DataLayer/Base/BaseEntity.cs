using System;
using System.Collections.Generic;
using System.Text;

namespace TrainDiary.DataLayer.Base
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Uuid { get; set; }
    }
}
