using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.Model
{
    using System.Collections.Generic;

    namespace GerenciadorTarefas.Model
    {
        public class TarefasModel
        {
            private List<Tarefa> tarefas;
            private int proximoId;

            public TarefasModel()
            {
                tarefas = new List<Tarefa>();
                proximoId = 1; 
            }

            public void AdicionarTarefa(Tarefa tarefa)
            {
                tarefas.Add(tarefa);
                proximoId++;
            }

            public void RemoverTarefa(int id)
            {
                tarefas.RemoveAll(t => t.Id == id);
            }

            public List<Tarefa> ListarTarefas()
            {
                return tarefas;
            }

            public Tarefa ObterTarefaPorId(int id)
            {
                return tarefas.Find(t => t.Id == id);
            }

            public int ObterProximoId()
            {
                return proximoId;
            }
        }
    }
}

