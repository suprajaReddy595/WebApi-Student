﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public String Batch { get; set; }
        public int? Marks { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }
}