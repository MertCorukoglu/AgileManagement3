using AgileManagement.Application.dtos.sprint;
using AgileManagement.Application.services.sprint;
using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.validators
{
    public class AddSprintValidator : IAddSprintValidator
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectWithSprintRequestService _projectWithSprintRequestService;

        public AddSprintValidator(IProjectRepository projectRepository, IProjectWithSprintRequestService projectWithSprintRequestService)
        {
            _projectRepository = projectRepository;
            _projectWithSprintRequestService = projectWithSprintRequestService;
        }

        public List<string> Errors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(ProjectAddSprintRequestDto request)
        {
            var response = _projectWithSprintRequestService.OnProcess(new ProjectWithSprintRequestDto { ProjectId = request.ProjectId });
            var a = request.FinishDate - request.StartDate;
            
            if ((request.FinishDate - request.StartDate).TotalMilliseconds < 0)
            {
                throw new Exception("Başlangıç tarihi bitiş tarihinden önce olamaz.");
            }
            if (response.Project[0].Sprints.Count() >= 1 )
            {
                if ((request.StartDate - response.Project[0].Sprints.OrderByDescending(z=>z.SprintNo).First().FinishDate).TotalMilliseconds < 0)
                {
                    throw new Exception("Son sprint tarihi girdiğiniz tarihten büyüktür.Lütfen geçerli bir tarih giriniz.");
                }
            }
            
            return true;
            
        }

    }
}
