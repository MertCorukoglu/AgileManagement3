using AgileManagement.Application.dtos.sprint;
using AgileManagement.Application.services.sprint;
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
        

        public ProjectAddSprintService(IProjectRepository projectRepository, IAddSprintValidator addSprintValidator, IProjectWithSprintRequestService projectWithSprintRequestService)
        {
            _projectRepository = projectRepository;
            _addSprintValidator = addSprintValidator;
            
        }
        public bool OnProcess(ProjectAddSprintRequestDto request)
        {
            
            var isValid = _addSprintValidator.IsValid(request);
            if (isValid)
            {
                return true;
            }
            //var response = new ProjectAddSprintResponseDto();
            //var project = _projectRepository.GetQuery()
            //    .Include(x => x.Sprints)
            //    .FirstOrDefault(x => x.Id == request.ProjectId);
            //var sprint = project.Sprints.FirstOrDefault(x => x.ProjectId == request.ProjectId);
            //int sprintCount = project.Sprints.Select(x => x.SprintNo).Count();
            //int sprintNo;
            //if (sprintCount < 1)
            //{
            //    sprintNo = 1;
            //}
            //sprintNo =(sprintCount + 1);
            
            //sprint.AddSprintNo(sprintNo.ToString());
            
            return false;
        }
    }
}
