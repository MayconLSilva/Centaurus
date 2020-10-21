namespace Centaurus
{
    partial class FrmFiltroRelatorioParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltroRelatorioParticipantes));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonBuscarParticipante = new System.Windows.Forms.Button();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonVisualizar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodosParticipantes = new System.Windows.Forms.RadioButton();
            this.radioButtonFornecedor = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(189, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // buttonBuscarParticipante
            // 
            this.buttonBuscarParticipante.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarParticipante.Image")));
            this.buttonBuscarParticipante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarParticipante.Location = new System.Drawing.Point(210, 22);
            this.buttonBuscarParticipante.Name = "buttonBuscarParticipante";
            this.buttonBuscarParticipante.Size = new System.Drawing.Size(25, 25);
            this.buttonBuscarParticipante.TabIndex = 38;
            this.buttonBuscarParticipante.UseVisualStyleBackColor = true;
            this.buttonBuscarParticipante.Click += new System.EventHandler(this.buttonBuscarParticipante_Click);
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonVisualizar});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 186);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(534, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 50;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripButtonVisualizar
            // 
            this.toolStripButtonVisualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonVisualizar.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVisualizar.Image")));
            this.toolStripButtonVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVisualizar.Name = "toolStripButtonVisualizar";
            this.toolStripButtonVisualizar.Size = new System.Drawing.Size(74, 22);
            this.toolStripButtonVisualizar.Text = "VISUALIZAR";
            this.toolStripButtonVisualizar.Click += new System.EventHandler(this.toolStripButtonVisualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodosParticipantes);
            this.groupBox1.Controls.Add(this.radioButtonFornecedor);
            this.groupBox1.Controls.Add(this.radioButtonFuncionario);
            this.groupBox1.Controls.Add(this.radioButtonCliente);
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 61);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o tipo:";
            // 
            // radioButtonTodosParticipantes
            // 
            this.radioButtonTodosParticipantes.AutoSize = true;
            this.radioButtonTodosParticipantes.Location = new System.Drawing.Point(225, 23);
            this.radioButtonTodosParticipantes.Name = "radioButtonTodosParticipantes";
            this.radioButtonTodosParticipantes.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodosParticipantes.TabIndex = 3;
            this.radioButtonTodosParticipantes.TabStop = true;
            this.radioButtonTodosParticipantes.Text = "Todos";
            this.radioButtonTodosParticipantes.UseVisualStyleBackColor = true;
            // 
            // radioButtonFornecedor
            // 
            this.radioButtonFornecedor.AutoSize = true;
            this.radioButtonFornecedor.Location = new System.Drawing.Point(140, 23);
            this.radioButtonFornecedor.Name = "radioButtonFornecedor";
            this.radioButtonFornecedor.Size = new System.Drawing.Size(79, 17);
            this.radioButtonFornecedor.TabIndex = 2;
            this.radioButtonFornecedor.TabStop = true;
            this.radioButtonFornecedor.Text = "Fornecedor";
            this.radioButtonFornecedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionario
            // 
            this.radioButtonFuncionario.AutoSize = true;
            this.radioButtonFuncionario.Location = new System.Drawing.Point(60, 23);
            this.radioButtonFuncionario.Name = "radioButtonFuncionario";
            this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionario.TabIndex = 1;
            this.radioButtonFuncionario.TabStop = true;
            this.radioButtonFuncionario.Text = "Funcionário";
            this.radioButtonFuncionario.UseVisualStyleBackColor = true;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Location = new System.Drawing.Point(6, 23);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCliente.TabIndex = 0;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // FrmFiltroRelatorioParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.buttonBuscarParticipante);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFiltroRelatorioParticipantes";
            this.Text = "Relatório de Participantes";
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonBuscarParticipante;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripButton toolStripButtonVisualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFuncionario;
        private System.Windows.Forms.RadioButton radioButtonCliente;
        private System.Windows.Forms.RadioButton radioButtonTodosParticipantes;
        private System.Windows.Forms.RadioButton radioButtonFornecedor;
    }
}