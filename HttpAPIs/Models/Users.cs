﻿using System;

namespace HttpAPIs.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
        public string Gender { get; set; }
    }
}
