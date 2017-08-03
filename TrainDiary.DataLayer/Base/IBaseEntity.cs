using System;

namespace TrainDiary.DataLayer.Base
{
    public interface IBaseEntity
    {
        Guid Uuid { get; set; }
    }
}