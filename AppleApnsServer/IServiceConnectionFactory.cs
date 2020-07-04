using System;

namespace AppleApnsServer
{
    public interface IServiceConnectionFactory<TNotification> where TNotification : INotification
    {
        IServiceConnection<TNotification> Create ();
    }
}

