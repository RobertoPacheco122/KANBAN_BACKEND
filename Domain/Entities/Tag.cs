using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Tag : BaseEntity {
        public string Name { get; set; } = string.Empty;
        public string BackgroundColorInHexa { get; set; } = string.Empty;
        public string TextColorInHexa { get;set; } = string.Empty;

        public List<TaskItem>? TaskItems { get; set; }
    }
}
