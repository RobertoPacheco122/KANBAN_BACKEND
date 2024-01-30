using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.List {
    public class ListAddDto {
        [Required(ErrorMessage = "É necessário fornecer o Id da List para realizar o inserir ou atualizar a List")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessário fornecer o Id do Board para realizar o inserir ou atualizar a List")]
        public Guid BoardId { get; set; }
        
    }
}
