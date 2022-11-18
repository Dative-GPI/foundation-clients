using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Foundation.Clients.ViewModels.Admin
{
    public class DeviceTwinViewModel
    {
        public Guid DeviceId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JsonElement? Tags { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JsonElement? DesiredProperties { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JsonElement? ReportedProperties { get; set; }
    }
}