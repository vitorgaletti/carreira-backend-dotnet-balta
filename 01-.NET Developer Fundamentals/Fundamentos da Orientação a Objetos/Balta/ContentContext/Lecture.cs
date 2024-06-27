#nullable disable

using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}