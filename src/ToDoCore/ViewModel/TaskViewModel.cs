
using ToDoCore.Model;

namespace ToDoCore.ViewModel
{
    public class TaskViewModel
    {
        public TaskViewModel(Task task)
        {
            Description = task.Description;
        }

        public string Description { get; set; }
    }
}
