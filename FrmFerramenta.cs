using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SysToolClass;

namespace Tool
{
    public partial class FrmFerramenta : Form
    {
        public FrmFerramenta()
        {
            InitializeComponent();
        }

        private void FrmFerramenta_Load(object sender, EventArgs e)
        {
            // Carrega categorias (caso precise para cadastrar a ferramenta)
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            // Carrega ferramentas no grid
            CarregaGridFerramentas();
        }

        // Carregar lista de ferramentas na grid
        private void CarregaGridFerramentas()
        {
            dgvFerramentas.Rows.Clear();
            var listaDeFerramentas = Ferramenta.ObterLista();
            int linha = 0;
            foreach (var ferramenta in listaDeFerramentas)
            {
                dgvFerramentas.Rows.Add();
                dgvFerramentas.Rows[linha].Cells[0].Value = ferramenta.Id;
                dgvFerramentas.Rows[linha].Cells[1].Value = ferramenta.Nome;
                dgvFerramentas.Rows[linha].Cells[2].Value = ferramenta.Categoria;
                dgvFerramentas.Rows[linha].Cells[3].Value = ferramenta.Descricao;
                dgvFerramentas.Rows[linha].Cells[4].Value = ferramenta.Potencia;
                dgvFerramentas.Rows[linha].Cells[5].Value = ferramenta.Preco;
                dgvFerramentas.Rows[linha].Cells[6].Value = ferramenta.QuantidadeEstoque;
                dgvFerramentas.Rows[linha].Cells[7].Value = ferramenta.Status;
                linha++;
            }
        }

        // Inserir uma nova ferramenta
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Ferramenta ferramenta = new(
                txtNome.Text,
                cmbCategoria.Text,
                txtDescricao.Text,
                Convert.ToDecimal(txtPotencia.Text),
                Convert.ToDecimal(txtPreco.Text),
                Convert.ToInt32(txtQuantidadeEstoque.Text),
                cmbStatus.Text
            );

            ferramenta.Inserir();

            if (ferramenta.Id > 0)
            {
                CarregaGridFerramentas();
                MessageBox.Show($"Ferramenta {ferramenta.Nome} inserida com sucesso");
            }
        }

        // Selecionar ferramenta no DataGridView
        private void dgvFerramentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvFerramentas.CurrentRow.Index;
            int idFerramenta = Convert.ToInt32(dgvFerramentas.Rows[linhaAtual].Cells[0].Value);
            var ferramenta = Ferramenta.ObterPorId(idFerramenta);

            txtID.Text = ferramenta.Id.ToString();
            txtNome.Text = ferramenta.Nome;
            cmbCategoria.Text = ferramenta.Categoria;
            txtDescricao.Text = ferramenta.Descricao;
            txtPotencia.Text = ferramenta.Potencia.ToString();
            txtPreco.Text = ferramenta.Preco.ToString();
            txtQuantidadeEstoque.Text = ferramenta.QuantidadeEstoque.ToString();
            cmbStatus.Text = ferramenta.Status;
        }

        // Atualizar informações da ferramenta
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Ferramenta ferramenta = new()
            {
                Id = int.Parse(txtID.Text),
                Nome = txtNome.Text,
                Categoria = cmbCategoria.Text,
                Descricao = txtDescricao.Text,
                Potencia = Convert.ToDecimal(txtPotencia.Text),
                Preco = Convert.ToDecimal(txtPreco.Text),
                QuantidadeEstoque = Convert.ToInt32(txtQuantidadeEstoque.Text),
                Status = cmbStatus.Text
            };

            if (ferramenta.Atualizar())
            {
                CarregaGridFerramentas();
                MessageBox.Show("Ferramenta atualizada com sucesso");
            }
        }

        // Excluir ferramenta
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esta ferramenta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Ferramenta ferramenta = new() { Id = int.Parse(txtID.Text) };
                ferramenta.Excluir();
                CarregaGridFerramentas();
                MessageBox.Show("Ferramenta excluída com sucesso");
            }
        }

        // Atualizar quantidade de estoque 
        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            Ferramenta ferramenta = new()
            {
                Id = int.Parse(txtID.Text),
                QuantidadeEstoque = Convert.ToInt32(txtQuantidadeEstoque.Text)
            };

            ferramenta.Atualizar();

            MessageBox.Show("Estoque atualizado com sucesso");
        }
    }
}
