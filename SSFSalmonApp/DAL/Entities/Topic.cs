﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSFSalmonApp.DAL.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User WrittenByUser { get; set; }
        public String Header { get; set; }
        public List<Comment> Comments { get; set; }
    }
}