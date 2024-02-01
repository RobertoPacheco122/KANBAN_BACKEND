using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Tag {
    public class TagDto : BaseEntity {
        public string Name { get; set; } = string.Empty;
        public string BackgroundColorInHexa { get; set; } = string.Empty;
        public string TextColorInHexa { get; set; } = string.Empty;
    }
}
