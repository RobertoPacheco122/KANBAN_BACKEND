using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class ListEntity : BaseEntity {
        public string Name { get; set; } = string.Empty;

        public Guid BoardId { get; set; }
        [JsonIgnore]
        public BoardEntity? Board { get; set; }
        public List<TaskEntity>? Tasks { get; set; }
    }
}
