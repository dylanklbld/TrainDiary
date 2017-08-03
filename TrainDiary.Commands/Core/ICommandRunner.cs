using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainDiary.Commands.Core
{
    public interface ICommandRunner<TParam, TResult>
    {
        TResult Execute(TParam command);

        Task<TResult> ExecuteAsync(TParam command);
    }

    public interface ICommandRunner<TParam>
    {
        Task ExecuteAsync(TParam command);
    }
}
