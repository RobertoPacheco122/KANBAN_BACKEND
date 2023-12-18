using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class SubtaskEntity : BaseEntity {
        public string Description { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;

        public Guid TaskId { get; set; }
        public TaskEntity? Task { get; set; }
    }
}
