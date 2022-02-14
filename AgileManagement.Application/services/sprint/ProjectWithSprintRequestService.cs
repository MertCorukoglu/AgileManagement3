using AgileManagement.Application.dtos.sprint;
using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.services.sprint
{
    public class ProjectWithSprintRequestService : IProjectWithSprintRequestService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectWithSprintRequestService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public ProjectWithSprintResponseDto OnProcess(ProjectWithSprintRequestDto request)
        {
            var project = _projectRepository.GetQuery().Where(x => x.Id == request.ProjectId).Include(x => x.Sprints).Select(a => new ProjectSprintDto
            {
                ProjectId = a.Id,
                Name = a.Name,
                Description = a.Description,
                Sprints = a.Sprints.OrderByDescending(b=>b.SprintName).Reverse().Select(x => new SprintDto
                {
                    StartDate = x.StartDate,
                    FinishDate = x.FinishDate,
                    SprintName = x.SprintName
                }).ToList()

            }).ToList();


            var response = new ProjectWithSprintResponseDto
            {
                Project = project
            };
            
            return response;
        }
    }
}
