﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Applicant : User
    {
       
        public string About {  get; set; }
        
        public   ICollection<Application> Applications { get; set; }
        public Applicant()
        {
            Applications = new HashSet<Application>();
        }
        
        public Applicant(string about)
        {
            About = about;
        }
    }
}
