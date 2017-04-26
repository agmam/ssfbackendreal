using System;

namespace SSFSalmonApp.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Topic Topicid { get; set; }
        public String Comments { get; set; }
        public User WritteByUser { get; set; }
    }
}