﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : BaseEntity<int>
    {
        public int Id { get; set; }
        public string  UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int NationalIdentity { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {
        }
        public User(string userName, string firstName, string lastName, DateTime dateOfBirth, int nationalIdentity, string email, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalIdentity = nationalIdentity;
            Email = email;
            Password = password;
        }
    }
}
