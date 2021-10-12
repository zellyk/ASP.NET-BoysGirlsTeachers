using System.Collections.Generic;

namespace BoysNGirls.Models.Tasks
{
    public class TeacherTaskService : ITaskService
    {
        public List<Task> GetTasks()
        {
            //Return hardcoded list containing tasks for a teacher

            return new List<Task>
            {
                new Task
                {
                    Code = "100A10",
                    Description = "Grading scripts",
                    Location = "F-251"
                },
                new Task
                {
                    Code = "100A11",
                    Description = "Teaching the class",
                    Location = "F-249"
                },
                new Task
                {
                    Code = "100A12",
                    Description = "Consulting with students",
                    Location = "F-251"
                },
                new Task
                {
                    Code = "100A13",
                    Description = "Having meeting with admin",
                    Location = "E-199"
                }
            };

        }

        string ITaskService.GetType()
        {
            return "teacher";
        }
    }
}
