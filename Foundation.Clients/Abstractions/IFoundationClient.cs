namespace Foundation.Clients.Abstractions
{
    public interface IFoundationClient
    {
        void Init(string host, string languageCode, string jwt = null);
        IAdminFoundationClient Admin { get; }
        ICoreFoundationClient Core { get; }
        IGatewayFoundationClient Gateway { get; }
        IDispatcherFoundationClient Dispatcher { get; }
    }
}