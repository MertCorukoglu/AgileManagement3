using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.dtos.sprint
{
    public class SprintErrorDto
    {
        public List<string> Errors { get; set; } = new List<string>();
    }
}
