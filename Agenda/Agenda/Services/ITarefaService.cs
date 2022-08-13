using Agenda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Services
{
    public interface ITarefaService
    {
        public List<Tarefa> retornarListaDeTarefas();
        public Tarefa retornarTarefaPorID(int id);
        public bool adicionarTarefa(Tarefa tarefa);
        public bool deletarTarefa(int id);
        public bool alterarTarefa(Tarefa novaTarefa);
    }
}
