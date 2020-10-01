namespace Centaurus
{
    partial class FrmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuarios));
            this.textBoxUsuarioClicado = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelecionarUsuario = new System.Windows.Forms.ToolStripButton();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsuarioClicado
            // 
            this.textBoxUsuarioClicado.Enabled = false;
            this.textBoxUsuarioClicado.Location = new System.Drawing.Point(12, 12);
            this.textBoxUsuarioClicado.Name = "textBoxUsuarioClicado";
            this.textBoxUsuarioClicado.Size = new System.Drawing.Size(250, 20);
            this.textBoxUsuarioClicado.TabIndex = 2;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(660, 239);
            this.dataGridViewUsuarios.TabIndex = 3;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelecionarUsuario});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 50;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripButtonSelecionarUsuario
            // 
            this.toolStripButtonSelecionarUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarUsuario.Image")));
            this.toolStripButtonSelecionarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarUsuario.Name = "toolStripButtonSelecionarUsuario";
            this.toolStripButtonSelecionarUsuario.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarUsuario.Text = "SELECIONAR";
            this.toolStripButtonSelecionarUsuario.Click += new System.EventHandler(this.toolStripButtonSelecionarUsuario_Click);
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(12, 303);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 51;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // FrmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.textBoxUsuarioClicado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaUsuarios";
            this.Text = "Consulta de Usuários";
            this.Load += new System.EventHandler(this.FrmConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuarioClicado;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarUsuario;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
    }
}