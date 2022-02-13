using AgileManagement.Application.dtos.sprint;
using AgileManagement.Application.validators;
using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application
{
    public class ProjectAddSprintService : IProjectAddSprintService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IAddSprintValidator _addSprintValidator;

        public ProjectAddSprintService(IProjectRepository projectRepository, IAddSprintValidator addSprintValidator)
        {
            _projectRepository = projectRepository;
            _addSprintValidator = addSprintValidator;
        }
        public ProjectAddSprintResponseDto OnProcess(ProjectAddSprintRequestDto request)
        {
            var isValid = _addSprintValidator.IsValid(request);
            var response = new ProjectAddSprintResponseDto();
            var project = _projectRepository.GetQuery()
                .Include(x => x.Sprints)
                .FirstOrDefault(x => x.Id == request.ProjectId);
            var sprint = project.Sprints.FirstOrDefault(x => x.ProjectId == request.ProjectId);
            int sprintCount = project.Sprints.Select(x => x.SprintNo).Count();
            var sprintNo = "S" +(sprintCount + 1).ToString();
            
            sprint.AddSprintNo(sprintNo);
            
            return response;
        }
    }
}
