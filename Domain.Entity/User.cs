﻿using System;

namespace Domain.Entity
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
