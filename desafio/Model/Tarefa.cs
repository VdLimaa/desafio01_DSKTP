using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Prioridade { get; set; } 
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; } 

        public Tarefa(int id, string nome, string prioridade, DateTime dataVencimento)
        {
            Id = id;
            Nome = nome;
            Prioridade = prioridade;
            DataVencimento = dataVencimento;
            Status = "Pendente"; 
        }

        public void MarcarComoConcluida()
        {
            Status = "Concluída";
        }
    }
}
