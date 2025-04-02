using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace desafio.Model
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    namespace GerenciadorTarefas.Model
    {
        public class TarefasModel
        {
            private List<Tarefa> tarefas;
            private int proximoId;
            private readonly string caminhoArquivo = "tarefas.xml";

            public TarefasModel()
            {
                tarefas = new List<Tarefa>();
                proximoId = 1;
                CarregarDoXML();
            }

            public void AdicionarTarefa(Tarefa tarefa)
            {
                tarefa.Id = proximoId;
                tarefas.Add(tarefa);
                proximoId++;
                SalvarNoXML();
            }

            public void RemoverTarefa(int id)
            {
                tarefas.RemoveAll(t => t.Id == id);
                SalvarNoXML();
            }

            public List<Tarefa> ListarTarefas()
            {
                return tarefas;
            }

            public Tarefa ObterTarefaPorId(int id)
            {
                return tarefas.Find(t => t.Id == id);
            }

            public void AtualizarTarefa(Tarefa tarefaAtualizada)
            {
                var tarefaExistente = ObterTarefaPorId(tarefaAtualizada.Id);
                if (tarefaExistente != null)
                {
                    
                    tarefaExistente.Nome = tarefaAtualizada.Nome;
                    tarefaExistente.Prioridade = tarefaAtualizada.Prioridade;
                    tarefaExistente.DataVencimento = tarefaAtualizada.DataVencimento;
                    tarefaExistente.Status = tarefaAtualizada.Status;

                    SalvarNoXML(); 
                }
            }

            public int ObterProximoId()
            {
                return proximoId;
            }

            private void SalvarNoXML()
            {
                try
                {
                    using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Tarefa>));
                        serializer.Serialize(stream, tarefas);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar XML: " + ex.Message);
                }
            }

            private void CarregarDoXML()
            {
                try
                {
                    if (File.Exists(caminhoArquivo))
                    {
                        using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Open))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(List<Tarefa>));
                            tarefas = (List<Tarefa>)serializer.Deserialize(stream);

                            if (tarefas.Count > 0)
                                proximoId = tarefas.Max(t => t.Id) + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar XML: " + ex.Message);
                    tarefas = new List<Tarefa>(); 
                }
            }
        }
    }
}

