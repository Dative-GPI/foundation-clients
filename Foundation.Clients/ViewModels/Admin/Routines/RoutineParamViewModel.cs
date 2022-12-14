using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class RoutineParamViewModel
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public DataType Type { get; set; }
        public List<ListOptionViewModel> Options { get; set; }
    }

    public class ListOptionViewModel
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }
    
    public enum DataType
    {
        Unknown = 0,
        Number = 1,
        ByteArray = 2,
        Boolean = 3,
        String = 4,
        DateTime = 5,
        List = 6
    }
}