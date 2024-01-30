using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.List {
    public class ListUpdateDto {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid BoardId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
