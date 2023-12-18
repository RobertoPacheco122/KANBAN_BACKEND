using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class BoardEntity : BaseEntity {
        public string Name { get; set; } = string.Empty;

        public List<ListEntity>? Lists { get; set; }
    }
}
