namespace Foundation.Clients.Services
{
    public static class ShellFoundationRoutes
    {
        public const string MODELS_PATH = "api/v1/models";
        public const string DEVICE_ORGANISATIONS_PATH = "api/v1/devices";
        public const string ORGANISATIONS_PATH = "api/v1/organisations";
        public const string USER_ORGANISATIONS_PATH = "api/v1/user-organisations";
        public const string PERMISSIONS_PATH = "api/v1/permissions/current";
    }

    public static class AdminFoundationRoutes
    {
        public const string DEVICE_PATH = "/api/admin/v1/devices";
        public const string DEVICE_TWIN_PATH = "/api/admin/v1/device-twins";
        public const string DEVICE_ORGANISATION_PATH = "/api/admin/v1/device-organisations";
        public const string DEVICE_SOURCES_PATH = "/api/admin/v1/device-sources";
        public const string ORGANISATION_PATH = "/api/admin/v1/organisations";
        public const string ORGANISATION_TYPE_PATH = "/api/admin/v1/organisation-types";
        public const string USER_APPLICATIONS_PATH = "api/admin/v1/users";
        public const string CURRENT_PERMISSIONS_ADMIN_PATH = "api/admin/v1/permissions-admin/current";
        public const string SOURCES_PATH = "api/admin/v1/sources";
        public const string ROUTINES_PATH = "api/admin/v1/routines";
    }

    public static class GatewayFoundationRoutes
    {
        public const string USERS_PATH = "/api/v1/users";
        public const string ACCOUNTS_PATH = "/api/v1/accounts";
        public const string TRANSLATIONS_PATH = "/api/v1/translations";
    }

    public static class DispatcherFoundationRoutes
    {
        public const string ROUTINES_PATH = "api/dispatcher/v1/routines";
    }
}