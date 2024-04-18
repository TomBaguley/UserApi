namespace UserApi.Models
{
    public class Job
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime StartDate { get; set; }
        public string? Assignee { get; set; }
        
    }
}
