using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels
{
    public class DeviceOptionViewModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        
        #region Translated properties
        public string KeyLabel { get; set; }
        public string ValueLabel { get; set; }
        #endregion

        public List<DeviceOptionTranslationViewModel> Translations { get; set; }
    }

    public class DeviceOptionTranslationViewModel
    {
        public string LanguageCode { get; set; }
        public string KeyLabel { get; set; }
        public string ValueLabel { get; set; }
    }
}