﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileManagement.Mvc.Models
{
    public class ContributorInputModel
    {
        public List<string> UsersId { get; set; }
        public string ProjectId { get; set; }

    }
}