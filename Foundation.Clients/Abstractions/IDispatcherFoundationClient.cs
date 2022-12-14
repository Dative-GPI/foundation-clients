using Foundation.Clients.Abstractions.Dispatcher;

namespace Foundation.Clients.Abstractions
{
    public interface IDispatcherFoundationClient
    {
        void Init(IFoundationClient root);

        IDispatcherRoutineFoundationClient Routines { get; }
    }
}