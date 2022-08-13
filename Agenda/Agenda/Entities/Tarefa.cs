using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Entities
{
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public string prazo { get; set; }
        public bool completa { get; set; }

    }
}
