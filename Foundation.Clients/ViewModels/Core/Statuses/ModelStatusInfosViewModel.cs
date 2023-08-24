using System;

namespace Foundation.Clients.ViewModels.Core
{
    public class ModelStatusInfosViewModel
    {
        public Guid Id { get; set; }
        public Guid ModelId { get; set; }
        public Guid DataDefinitionId { get; set; }
        public Guid? GroupById { get; set; }
        public int Lifetime { get; set; }
        public int? TimeToLive { get; set; }
        public bool ShowDefault { get; set; }
        public string IconDefault { get; set; }
        public string ColorDefault { get; set; }
        public int Index { get; set; }

        #region Translated properties
        public string Label { get; set; }
        public string GroupByLabel { get; set; }
        #endregion
    }
}