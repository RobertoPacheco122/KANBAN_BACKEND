using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Task {
    public class TaskAddDto {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ETaskPriority? Priority { get; set; }
        public bool IsDone { get; set; } = false;
        public DateOnly? DueDate { get; set; }
        public DateOnly? DoneDate { get; set; }
        public Guid ListId { get; set; }
    }
}
