namespace BlogSpotMvc.Models
{
    public class MvcBlog
    {
        public int? BlogId { get; set; }
        public string Title { get; set; } = null!;
        public string? Subject { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string? BlogUrl { get; set; }
        public string? EmpEmailId { get; set; }

        public virtual MvcEmployee? EmpEmail { get; set; }
    }
}
