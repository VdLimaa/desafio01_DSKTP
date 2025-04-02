using desafio.Model.GerenciadorTarefas.Model;
using desafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.Controller
{
    public class TarefaController
    {
        private TarefasModel modelo;

        public TarefaController()
        {
            modelo = new TarefasModel();
        }

        public void AdicionarTarefa(string nome, string prioridade, DateTime dataVencimento)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O nome da tarefa não pode estar vazio.");
            if (string.IsNullOrWhiteSpace(prioridade))
                throw new Exception("A prioridade deve ser selecionada.");

            int id = modelo.ObterProximoId();
            Tarefa tarefa = new Tarefa(id, nome, prioridade, dataVencimento);
            modelo.AdicionarTarefa(tarefa);
        }

        public void MarcarComoConcluida(int id)
        {
            Tarefa tarefa = modelo.ObterTarefaPorId(id);
            if (tarefa == null)
                throw new Exception("Tarefa não encontrada.");
            tarefa.MarcarComoConcluida();
            modelo.AtualizarTarefa(tarefa);
        }

        public List<Tarefa> ListarTarefas()
        {
            return modelo.ListarTarefas();
        }

        public Dictionary<string, int> ObterContagemPorPrioridade()
        {
            var contagem = new Dictionary<string, int>
            {
                { "Alta", 0 },
                { "Média", 0 },
                { "Baixa", 0 }
            };

            foreach (var tarefa in modelo.ListarTarefas())
            {
                if (contagem.ContainsKey(tarefa.Prioridade))
                    contagem[tarefa.Prioridade]++;
            }

            return contagem;
        }
    }
}
