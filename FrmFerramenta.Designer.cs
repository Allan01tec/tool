namespace Tool
{
    partial class FrmFerramenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvFerramentas = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.PlaceholderText = "Nome da Ferramenta";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(12, 68);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 24);
            this.cmbCategoria.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 98);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(300, 22);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.PlaceholderText = "Descrição da Ferramenta";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(12, 126);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(200, 22);
            this.txtPotencia.TabIndex = 4;
            this.txtPotencia.PlaceholderText = "Potência (em watts)";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 154);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(200, 22);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.PlaceholderText = "Preço da Ferramenta";
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(12, 182);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(200, 22);
            this.txtQuantidadeEstoque.TabIndex = 6;
            this.txtQuantidadeEstoque.PlaceholderText = "Quantidade em Estoque";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 210);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // dgvFerramentas
            // 
            this.dgvFerramentas.AllowUserToAddRows = false;
            this.dgvFerramentas.AllowUserToDeleteRows = false;
            this.dgvFerramentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramentas.Location = new System.Drawing.Point(12, 250);
            this.dgvFerramentas.Name = "dgvFerramentas";
            this.dgvFerramentas.ReadOnly = true;
            this.dgvFerramentas.RowTemplate.Height = 24;
            this.dgvFerramentas.Size = new System.Drawing.Size(760, 200);
            this.dgvFerramentas.TabIndex = 8;
            this.dgvFerramentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFerramentas_CellClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 460);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 30);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(118, 460);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(224, 460);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizarEstoque
            // 
            this.btnAtualizarEstoque.Location = new System.Drawing.Point(330, 460);
            this.btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            this.btnAtualizarEstoque.Size = new System.Drawing.Size(150, 30);
            this.btnAtualizarEstoque.TabIndex = 12;
            this.btnAtualizarEstoque.Text = "Atualizar Estoque";
            this.btnAtualizarEstoque.UseVisualStyleBackColor = true;
            this.btnAtualizarEstoque.Click += new System.EventHandler(this.btnAtualizarEstoque_Click);
            // 
            // FrmFerramenta
            // 
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btnAtualizarEstoque);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvFerramentas);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtQuantidadeEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Name = "FrmFerramenta";
            this.Text = "Gerenciar Ferramentas";
            this.Load += new System.EventHandler(this.FrmFerramenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvFerramentas;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizarEstoque;
    }
}
