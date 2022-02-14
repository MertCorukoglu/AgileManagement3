using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain.models
{
    public class Sprint : Entity
    {
        public string SprintName { get;private set; }
        public DateTime StartDate { get;private set; }
        public DateTime FinishDate { get;private set; }
        public Sprint(DateTime startDate, DateTime finishDate)
        {
            Id = Guid.NewGuid().ToString();
            AddSprintTime(startDate, finishDate);
        }

        private void AddSprintTime (DateTime startDate, DateTime finishDate)
        {
            
            
            

            this.StartDate = startDate;
            this.FinishDate = finishDate;
        }

        public void SetSprintName (int sprintCount)
        {
            
            this.SprintName = "Sprint"+ sprintCount;
        }
  
    }
}
