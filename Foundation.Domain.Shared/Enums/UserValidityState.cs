using System;

namespace Foundation.Domain.Shared
{
    [Flags]
    public enum UserValidityState
    {
        InvitationNotSended = 0x000,
        InvitationSended = 0x001,
        AccountCreated = 0x011,
        AccountValidated = 0x111
    }
}