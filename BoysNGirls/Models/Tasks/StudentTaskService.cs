using System.Collections.Generic;

namespace BoysNGirls.Models.Tasks
{
    public class StudentTaskService : ITaskService
    {
        public List<Task> GetTasks()
        {
            //Return hardcoded list containing tasks for students
            return new List<Task>
            {
                new Task
                {
                    Code="200B10",
                    Description = "Attend classes",
                    Location = "F-249"
                },
                new Task
                {
                    Code="200B11",
                    Description = "Do some tutoring",
                    Location = "A-103"
                },
                new Task
                {
                    Code="200B12",
                    Description = "Make some friends",
                    Location = "College"
                },
                new Task
                {
                    Code="200B13",
                    Description = "Score good grades",
                    Location = "Department"
                }
            };

        }

        string ITaskService.GetType()
        {
            return "student";
        }
    }
}
