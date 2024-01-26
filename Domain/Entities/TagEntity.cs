using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class TagEntity : BaseEntity {
        public string Name { get; set; } = string.Empty;
        public string BackgroundColorInHexa { get; set; } = string.Empty;
        public string TextColorInHexa { get;set; } = string.Empty;

        [JsonIgnore]
        public List<TaskEntity>? Tasks { get; set; }
    }
}
