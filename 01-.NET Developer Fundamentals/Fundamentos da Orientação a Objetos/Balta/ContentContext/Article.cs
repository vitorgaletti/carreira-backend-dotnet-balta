using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public class Article : Content
    {
        public IList<Notification> Nofications { get; set; }


        public Article(string title, string url) : base(title, url)
        {

        }
    }
}