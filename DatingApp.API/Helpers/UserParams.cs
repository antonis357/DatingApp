namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        public int PageNumber { get; set; } = 1;

        private const int MaxPageSize = 50;
        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize: value; }
        }
        
    }
}