using AgileManagement.Application.dtos.sprint;
using AgileManagement.Core;
using AgileManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application
{
    public interface IProjectAddSprintService : IApplicationService<ProjectAddSprintRequestDto, bool>
    {


    }
}