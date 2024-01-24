namespace BlogSpotMvc.Models
{
    public class MvcEmployee
    {
        public MvcEmployee()
        {
            BlogInfos = new HashSet<MvcBlog>();
        }

        public string EmailId { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime? DatOfJoining { get; set; }
        public int? PassCode { get; set; }

        public virtual ICollection<MvcBlog> BlogInfos { get; set; }
    }
}
