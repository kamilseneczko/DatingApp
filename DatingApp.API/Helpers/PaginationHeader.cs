namespace DatingApp.API.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }

        public int itemsPerPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public PaginationHeader(int CurrentPage, int itemsPerPage, int TotalItems, int TotalPages)
        {
            this.CurrentPage = CurrentPage;
            this.itemsPerPage = itemsPerPage;
            this.TotalItems = TotalItems;
            this.TotalPages = TotalPages;
        }
    }
}