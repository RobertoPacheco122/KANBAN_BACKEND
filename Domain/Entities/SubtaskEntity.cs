﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class SubtaskEntity : BaseEntity {
        public string Description { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;

        public Guid TaskId { get; set; }
        [JsonIgnore]
        public TaskEntity? Task { get; set; }
    }
}
