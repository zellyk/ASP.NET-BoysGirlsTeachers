using System.Collections.Generic;

namespace BoysNGirls.Models.Tasks
{
    // Interface for the Task Service
    public interface ITaskService
    {
        List<Task> GetTasks();

        // Returns type of task
        // This is used as opposed to a type assertion to avoid coupling of the TaskService implementation to its dependents
        string GetType();
    }
}
