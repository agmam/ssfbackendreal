using System;

namespace SSFSalmonApp.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Topic Topic { get; set; }
        public String Content { get; set; }
        public User WritteByUser { get; set; }
    }
}