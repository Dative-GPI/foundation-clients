using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateOrganisationAdminViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string LanguageCode { get; set; }
        public string TimeZoneId { get; set; }
    }
}