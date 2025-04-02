namespace desafio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.chartPrioridades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMarcarConcluida = new System.Windows.Forms.Button();
            this.btnGerarGrafico = new System.Windows.Forms.Button();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.lbVencimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrioridades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(395, 30);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(771, 241);
            this.dgvTarefas.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(15, 196);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cmbPrioridade.Location = new System.Drawing.Point(122, 76);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(121, 23);
            this.cmbPrioridade.TabIndex = 2;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimento.Location = new System.Drawing.Point(133, 125);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(216, 22);
            this.dtpDataVencimento.TabIndex = 3;
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTarefa.Location = new System.Drawing.Point(122, 27);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(121, 22);
            this.txtNomeTarefa.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(43, 15);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Tarefa:";
            // 
            // chartPrioridades
            // 
            this.chartPrioridades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chartPrioridades.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chartPrioridades.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrioridades.Legends.Add(legend1);
            this.chartPrioridades.Location = new System.Drawing.Point(15, 292);
            this.chartPrioridades.Name = "chartPrioridades";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPrioridades.Series.Add(series1);
            this.chartPrioridades.Size = new System.Drawing.Size(383, 196);
            this.chartPrioridades.TabIndex = 6;
            this.chartPrioridades.Text = "chartPrioridades";
            // 
            // btnMarcarConcluida
            // 
            this.btnMarcarConcluida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarConcluida.Location = new System.Drawing.Point(263, 30);
            this.btnMarcarConcluida.Name = "btnMarcarConcluida";
            this.btnMarcarConcluida.Size = new System.Drawing.Size(86, 70);
            this.btnMarcarConcluida.TabIndex = 7;
            this.btnMarcarConcluida.Text = "Marcar como Concluída";
            this.btnMarcarConcluida.UseVisualStyleBackColor = true;
            this.btnMarcarConcluida.Click += new System.EventHandler(this.btnMarcarConcluida_Click);
            // 
            // btnGerarGrafico
            // 
            this.btnGerarGrafico.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarGrafico.Location = new System.Drawing.Point(122, 196);
            this.btnGerarGrafico.Name = "btnGerarGrafico";
            this.btnGerarGrafico.Size = new System.Drawing.Size(79, 23);
            this.btnGerarGrafico.TabIndex = 8;
            this.btnGerarGrafico.Text = "Gerar Gráfico";
            this.btnGerarGrafico.UseVisualStyleBackColor = true;
            this.btnGerarGrafico.Click += new System.EventHandler(this.btnGerarGrafico_Click);
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.AutoSize = true;
            this.lbPrioridade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrioridade.Location = new System.Drawing.Point(12, 79);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(64, 15);
            this.lbPrioridade.TabIndex = 9;
            this.lbPrioridade.Text = "Prioridade:";
            // 
            // lbVencimento
            // 
            this.lbVencimento.AutoSize = true;
            this.lbVencimento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVencimento.Location = new System.Drawing.Point(12, 131);
            this.lbVencimento.Name = "lbVencimento";
            this.lbVencimento.Size = new System.Drawing.Size(116, 15);
            this.lbVencimento.TabIndex = 10;
            this.lbVencimento.Text = "Data de Vencimento:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 522);
            this.Controls.Add(this.lbVencimento);
            this.Controls.Add(this.lbPrioridade);
            this.Controls.Add(this.btnGerarGrafico);
            this.Controls.Add(this.btnMarcarConcluida);
            this.Controls.Add(this.chartPrioridades);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNomeTarefa);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvTarefas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrioridades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrioridades;
        private System.Windows.Forms.Button btnMarcarConcluida;
        private System.Windows.Forms.Button btnGerarGrafico;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.Label lbVencimento;
    }
}

