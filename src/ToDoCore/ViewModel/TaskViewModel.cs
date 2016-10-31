
using ToDoCore.Model;

namespace ToDoCore.ViewModel
{
    public class TaskViewModel
    {
        public TaskViewModel()
        {
        }

        public TaskViewModel(Task task)
        {
            Description = task.Description;
            TaskId = task.TaskId;
        }

        public string Description { get; set; }
        public int TaskId { get; set; }
    }
}
