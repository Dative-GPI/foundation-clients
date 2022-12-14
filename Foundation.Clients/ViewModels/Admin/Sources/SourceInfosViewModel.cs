using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class SourceInfosViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
        public SourceType Type { get; set; }
    }
}