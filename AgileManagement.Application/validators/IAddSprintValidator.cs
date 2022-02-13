using AgileManagement.Application.dtos.sprint;
using AgileManagement.Core.validation;
using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.validators
{
    public interface IAddSprintValidator : IValidator<ProjectAddSprintRequestDto>
    {
    }
}
