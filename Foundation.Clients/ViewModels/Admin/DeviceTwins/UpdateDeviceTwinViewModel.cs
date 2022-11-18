using System.Text.Json;
using System.Text.Json.Serialization;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateDeviceTwinViewModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JsonElement Tags { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JsonElement DesiredProperties { get; set; }
    }
}