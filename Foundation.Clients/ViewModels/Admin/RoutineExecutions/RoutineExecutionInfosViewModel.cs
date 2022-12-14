using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class RoutineExecutionInfosViewModel
    {
        public Guid Id { get; set; }
        
        public Guid RoutineId { get; set; }
        public DateTime DateTime { get; set; }
        public Dictionary<string, string> Values { get; set; }

        public IEnumerable<RoutineExecutionStatusInfosViewModel> Statuses { get; set; }
    }
}