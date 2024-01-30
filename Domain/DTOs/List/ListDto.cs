using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.List {
    public class ListDto : BaseEntity {
        public string Name { get; set; } = string.Empty;
        public Guid BoardId { get; set; }
    }
}
