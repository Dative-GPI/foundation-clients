namespace Foundation.Clients.Abstractions
{
    public interface IFoundationClient
    {
        void Init(string adminHost, string shellHost, string languageCode, string jwt = null);
        IAdminFoundationClient Admin { get; }
        ICoreFoundationClient Core { get; }
        IGatewayFoundationClient Gateway { get; }
        IDispatcherFoundationClient Dispatcher { get; }
    }
}