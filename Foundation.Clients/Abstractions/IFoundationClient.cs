namespace Foundation.Clients.Abstractions
{
    public interface IFoundationClient
    {
        void Init(string adminHost, string shellHost, string languageCode, string jwt = null);
        IAdminFoundationClient Admin { get; }
        IShellFoundationClient Shell { get; }
        IGatewayFoundationClient Gateway { get; }
        IDispatcherFoundationClient Dispatcher { get; }
    }
}