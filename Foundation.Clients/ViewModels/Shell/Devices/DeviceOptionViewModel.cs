using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Shell
{
    public class DeviceOptionViewModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        #region Translated properties
        public string KeyLabel { get; set; }
        public string ValueLabel { get; set; }
        #endregion
    }
}