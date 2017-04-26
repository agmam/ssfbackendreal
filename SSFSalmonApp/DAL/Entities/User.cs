﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace SSFSalmonApp.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String PhoneNr { get; set; }
        public List<Fish> FishList { get; set; }
        public List<Topic> topics { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}