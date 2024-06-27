namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string ulr) : base(title, ulr)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        // Expression Body
    }
}