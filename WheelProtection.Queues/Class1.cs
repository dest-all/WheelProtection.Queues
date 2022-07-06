using System;

namespace WheelProtection.Queues
{
    public class QueueProcessor<TIn, TOut>
    {
        readonly Func<TIn, TOut> _do;
        public QueueProcessor(Func<TIn, TOut> @do)
        {
            _do = @do;
        }

        public TOut Do(TIn argument)
        {
            return _do(argument);
        }
    }
}