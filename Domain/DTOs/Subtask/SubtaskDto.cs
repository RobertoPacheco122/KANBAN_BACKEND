﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Subtask {
    public class SubtaskDto : BaseEntity {
        public string Description { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
        public Guid TaskId { get; set; }
    }
}
