using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileManagement.Mvc.Areas.Admin.Models
{
    public class RemoveSprintInputModel
    {
        public string ProjectId { get; set; }
        public string SprintName { get; set; }
    }
}
