using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.dtos.sprint
{
    public class SprintDto
    {

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }
        public int SprintNo { get; set; }
        public string SprintName { get; set; }

    }

    public class ProjectSprintDto
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }





        /// <summary>
        /// Projeye eklenen contributorler
        /// </summary>
        public List<SprintDto> Sprints { get; set; } = new List<SprintDto>();

    }
    public class ProjectWithSprintResponseDto
    {
        public List<ProjectSprintDto> Project = new List<ProjectSprintDto>();

    }
}
