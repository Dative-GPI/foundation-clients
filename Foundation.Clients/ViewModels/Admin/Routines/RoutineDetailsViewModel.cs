using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class RoutineDetailsViewModel
    {
        public Guid Id { get; set; }
        public bool Disabled { get; set; }

        public string Label { get; set; }
        public string SourceLabel { get; set; }

        public Guid SourceId { get; set; }
        public Guid RemoteId { get; set; }
        public IEnumerable<RoutineParamViewModel> Params { get; set; }
    }
}