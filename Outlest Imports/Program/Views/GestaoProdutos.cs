using Infra.Services;
using Infra.EF.Contexto;
using System;
using System.Windows.Forms;
using System.Linq;
using Domain.EF.Entity;

namespace Program.Views
{
    public partial class GestaoProdutos : Form
    {

        ProgramService _programService = new ProgramService();
        OutletImportsContext contexto = new OutletImportsContext();



        public GestaoProdutos()
        {
            InitializeComponent();
        }

        public void CarregaDados()
        {
            dgvProdutos.DataSource = contexto.Produtos.AsNoTracking().ToList<Produtos>();
        }


        private void GestaoProdutos_Load(object sender, EventArgs e)
        {
          this.CarregaDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvProdutos.CurrentRow.Index;

            txtNome.Text = dgvProdutos["Nome", sel].Value.ToString();
            txtDescricao.Text = dgvProdutos["Descricao", sel].Value.ToString();
            txtCompra.Text = dgvProdutos["Compra", sel].Value.ToString();
            txtVenda.Text = dgvProdutos["Venda", sel].Value.ToString();
            txtMarca.Text = dgvProdutos["Marca", sel].Value.ToString();
            txtModelo.Text = dgvProdutos["Modelo", sel].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, descricao, marca, modelo;
            decimal compra, venda;

            int sel = dgvProdutos.CurrentRow.Index;

            nome = txtNome.Text.Trim();
            descricao = txtDescricao.Text.Trim();
            compra = Convert.ToDecimal(txtCompra.Text);
            venda = Convert.ToDecimal(txtVenda.Text);
            marca = txtMarca.Text.Trim();
            modelo = txtModelo.Text.Trim();

            if (nome != "" || descricao != "" || compra != 0 || venda != 0 || marca != "" || modelo != "")
            {
                try
                {
                    var Registro = new Produtos()
                    {
                        Codigo = Convert.ToInt32(dgvProdutos["ID", sel].Value),
                        Nome = nome,
                        Descricao = descricao,
                        Compra = compra,
                        Venda = venda,
                        Marca = marca,
                        Modelo = modelo
                    };

                    _programService.AtualizaProdutos(Registro);

                    MessageBox.Show("Produto atualizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + String.Format(ex.Message), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int sel, codigo;
            sel = dgvProdutos.CurrentRow.Index;
            codigo = Convert.ToInt32(dgvProdutos["ID", sel].Value);

            

            if (codigo != 0)
            {
                try
                {
                    var Registro = new Produtos()
                    {
                        Codigo = codigo                        
                    };

                    _programService.ExcluiProdutos(Registro);

                    MessageBox.Show("Produto excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + String.Format(ex.Message), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CarregaDados();
        }
    }
}
