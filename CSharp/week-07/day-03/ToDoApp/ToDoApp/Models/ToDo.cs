﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Complete { get; set; }
        public bool IsUrgent { get; set; }
    }
}
