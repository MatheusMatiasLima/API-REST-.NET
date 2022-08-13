using Agenda.Context;
using Agenda.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly LocalDbContext localDb;

        public TarefaService(LocalDbContext localDb)
        {
            this.localDb = localDb;
        }

        public bool adicionarTarefa(Tarefa tarefa)
        {
            try { 
                localDb.Add(tarefa);
                localDb.SaveChanges();
                return true;
            }

            catch (Exception e) {
                return false;
            }
        }

        public bool alterarTarefa(Tarefa novaTarefa)
        {
            try
            {
                localDb.tarefa.Attach(novaTarefa);
                localDb.Entry(novaTarefa).State = EntityState.Modified;
                localDb.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deletarTarefa(int id)
        {
            try {
                Tarefa aSerApagado = localDb.tarefa.Where(d => d.id == id).FirstOrDefault();
                localDb.Remove(aSerApagado);
                localDb.SaveChanges();
                return true;
            }

            catch (Exception e) {
                return false;
            }
        }

        public List<Tarefa> retornarListaDeTarefas()
        {
            try { 
                return localDb.tarefa.ToList();
            }
            catch (Exception e) {
                return null;
            }
        }

        public Tarefa retornarTarefaPorID(int id)
        {
            try
            {
                return localDb.tarefa.Where(d => d.id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
