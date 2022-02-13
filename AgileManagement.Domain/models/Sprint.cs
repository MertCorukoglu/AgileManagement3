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
        public int SprintNo { get;private set; }

        public string ProjectId { get;private set; }
        public Sprint(DateTime startDate, DateTime finishDate, string projectId, int sprintNo)
        {
            Id = Guid.NewGuid().ToString();
            AddSprintTime(startDate, finishDate);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new Exception("ProjectId boş geçilemez.");
            }
            this.ProjectId = projectId;
            AddSprintNo(sprintNo);
            this.SprintName = "Sprint" + sprintNo;
        }

        public void AddSprintTime (DateTime startDate, DateTime finishDate)
        {
            
            if (finishDate.Minute < startDate.Minute)
            {
                throw new Exception("Bitiş tarihi başlangıç tarihinden önce olamaz.");
            }
            //if (DateTime.Now > startDate)
            //{
            //    throw new Exception("Geçmiş tarih girilemez.");
            //}

            this.StartDate = startDate;
            this.FinishDate = finishDate;
        }

        public void AddSprintNo (int sprintNo)
        {
            this.SprintNo = sprintNo;
        }
  
    }
}
