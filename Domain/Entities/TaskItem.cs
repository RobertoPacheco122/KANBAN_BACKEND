using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class TaskItem : BaseEntity {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority? Priority { get; set; }
        public bool IsDone { get; set; } = false;
        public DateOnly? DueDate { get; set; }

        public int ListId { get; set; }
        public List? List { get; set; }
        public List<ApplicationUser>? Users { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Subtask>? Subtasks { get; set; }

    }
}
