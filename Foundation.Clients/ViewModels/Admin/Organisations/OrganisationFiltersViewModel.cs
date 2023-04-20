namespace Foundation.Clients.ViewModels.Admin
{
    public class OrganisationFilterViewModel
    {
        public string Search { get; set; }
        
        public string SortBy { get; set; }
        public bool SortDesc { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}