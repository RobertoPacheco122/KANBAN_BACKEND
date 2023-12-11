using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class List : BaseEntity {
        public string Name { get; set; } = string.Empty;

        public int BoardId { get; set; }
        public Board? Board { get; set; }
        public List<TaskItem>? TaskItems { get; set; }
    }
}
