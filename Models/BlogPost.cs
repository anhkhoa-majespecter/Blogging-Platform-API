namespace Blogging_Platform_API.Models
{
    public class BlogPost
    {
        public  Int32 ID { get; set; }
        public String? Title { get; set; }
        public String? Content { get; set; }
        public String? Category { get; set; }
        public List<TagBlog> tags { get; set; } = new List<TagBlog>();
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
