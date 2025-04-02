using desafio.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace desafio
{
    public partial class Form1 : Form
    {
        private TarefaController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new TarefaController();
            ConfigurarInterface(); 
            AtualizarListaTarefas();

        }

        private void ConfigurarInterface()
        {
            dgvTarefas.Columns.Clear();
            dgvTarefas.Columns.Add("Id", "ID");
            dgvTarefas.Columns.Add("Nome", "Nome");
            dgvTarefas.Columns.Add("Prioridade", "Prioridade");
            dgvTarefas.Columns.Add("DataVencimento", "Data de Vencimento");
            dgvTarefas.Columns.Add("Status", "Status");

            chartPrioridades.Series.Clear();
            chartPrioridades.Series.Add("Prioridades");
            chartPrioridades.Series["Prioridades"].ChartType = SeriesChartType.Column;
            chartPrioridades.ChartAreas[0].AxisX.Title = "Prioridade";
            chartPrioridades.ChartAreas[0].AxisY.Title = "Quantidade de Tarefas";
        }

        private void AtualizarListaTarefas()
        {
            dgvTarefas.Rows.Clear();
            var tarefas = controller.ListarTarefas();
            foreach (var tarefa in tarefas)
            {
                dgvTarefas.Rows.Add(tarefa.Id, tarefa.Nome, tarefa.Prioridade, tarefa.DataVencimento.ToShortDateString(), tarefa.Status);
            }
        }

        private void AtualizarGrafico()
        {
            var contagem = controller.ObterContagemPorPrioridade();
            chartPrioridades.Series["Prioridades"].Points.Clear();
            chartPrioridades.Series["Prioridades"].Points.AddXY("Alta", contagem["Alta"]);
            chartPrioridades.Series["Prioridades"].Points.AddXY("Média", contagem["Média"]);
            chartPrioridades.Series["Prioridades"].Points.AddXY("Baixa", contagem["Baixa"]);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeTarefa.Text;
                string prioridade = cmbPrioridade.SelectedItem?.ToString();
                DateTime dataVencimento = dtpDataVencimento.Value;

                controller.AdicionarTarefa(nome, prioridade, dataVencimento);
                AtualizarListaTarefas();

                txtNomeTarefa.Clear();
                cmbPrioridade.SelectedIndex = 0;
                dtpDataVencimento.Value = DateTime.Now;

                MessageBox.Show("Tarefa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarConcluida_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTarefas.SelectedRows.Count == 0)
                    throw new Exception("Selecione uma tarefa para marcar como concluída.");

                int id = Convert.ToInt32(dgvTarefas.SelectedRows[0].Cells["Id"].Value);
                controller.MarcarComoConcluida(id);

                AtualizarListaTarefas();

                MessageBox.Show("Tarefa marcada como concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrafico();
                MessageBox.Show("Gráfico gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}