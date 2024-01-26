using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class TaskEntity : BaseEntity {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ETaskPriority? Priority { get; set; }
        public bool IsDone { get; set; } = false;
        public DateOnly? DueDate { get; set; }
        public DateOnly? DoneDate { get; set; }

        public Guid ListId { get; set; }
        [JsonIgnore]
        public ListEntity? List { get; set; }
        public List<ApplicationUserEntity>? Users { get; set; }
        public List<TagEntity>? Tags { get; set; }
        public List<SubtaskEntity>? Subtasks { get; set; }
    }
}
