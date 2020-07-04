using System;

namespace AppleApnsServer
{
    public interface INotification
    {
        bool IsDeviceRegistrationIdValid ();
        object Tag { get; set; }
    }
}
