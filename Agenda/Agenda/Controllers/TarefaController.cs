using Agenda.Entities;
using Agenda.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefaController : Controller
    {
        private readonly ILogger<TarefaController> logger;
        private readonly ITarefaService tarefa;

        public TarefaController(ILogger<TarefaController> logger, ITarefaService tarefa)
        {
            this.logger = logger;
            this.tarefa = tarefa;
        }

        [HttpPost]
        public IActionResult AdiconarTarefa([FromBody] Tarefa novaTarefa)
        {
            return Ok(tarefa.adicionarTarefa(novaTarefa));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(int id)
        {
            return Ok(tarefa.deletarTarefa(id));
        }

        [HttpPut]
        public IActionResult AlterarTarefa([FromBody] Tarefa novaTarefa)
        {
            return Ok( tarefa.alterarTarefa(novaTarefa));
        }

        [HttpGet]
        public IActionResult TodasAsTarefa()
        {
            return Ok(tarefa.retornarListaDeTarefas() );
        }

        [HttpGet("{id}")]
        public IActionResult RetornarTarefa(int id)
        {
            return Ok(tarefa.retornarTarefaPorID(id) );
        }


    }
}
