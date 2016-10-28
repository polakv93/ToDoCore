using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoCore.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        [MinLength(3)]
        public string Description { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}