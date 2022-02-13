using AgileManagement.Application.dtos.sprint;
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

        public AddSprintValidator(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public List<string> Errors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(ProjectAddSprintRequestDto @object)
        {
            var project = _projectRepository.GetQuery().Where(x => x.Id == @object.ProjectId).Include(x => x.Sprints).Select(g => g.Sprints).TakeLast(1);

            return true;
            

        }

    }
}
