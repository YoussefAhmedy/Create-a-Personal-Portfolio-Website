namespace WebApplication2.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Description { get; internal set; }
        public string Link { get; internal set; }
        public string Title { get; internal set; }
    }
}
