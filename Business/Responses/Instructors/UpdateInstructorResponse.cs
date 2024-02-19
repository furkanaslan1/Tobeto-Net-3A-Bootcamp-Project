﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Instructors
{
    public class UpdateInstructorResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}