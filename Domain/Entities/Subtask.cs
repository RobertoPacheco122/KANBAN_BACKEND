using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Subtask : BaseEntity {
        public string? Description { get; set; }
        public bool IsDone { get; set; } = false;

        public int TaskItemId { get; set; }
        public TaskItem? TaskItem { get; set; }
    }
}
