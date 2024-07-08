﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() {
            Name = "Unknown";
            Email = "Unknown";
            Password = "Unknown";
        }

        public User(string name, string email, string password) : this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Password: {Password}";
        }
    }
}
