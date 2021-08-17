using Domain.EF.Entity;
using Infra.Services;
using System;
using System.Windows.Forms;

namespace Program
{
    public partial class CadastroProdutos : Form
    {

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        ProgramService _programService = new ProgramService();



        public void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, descricao, marca, modelo;
            decimal compra, venda;

            nome = txtNome.Text.Trim();
            descricao = txtDescricao.Text.Trim();
            compra = Convert.ToDecimal(txtValorCompra.Text);
            venda = Convert.ToDecimal(txtValorVenda.Text);
            marca = txtMarca.Text.Trim();
            modelo = txtModelo.Text.Trim();



            if (nome != "" || descricao != "" || compra != 0 || venda != 0 || marca != "" || modelo != "")
            {
                try
                {
                    var Registro = new Produtos()
                    {
                        Nome = nome,
                        Descricao = descricao,
                        Compra = compra,
                        Venda = venda,
                        Marca = marca,
                        Modelo = modelo
                    };

                    _programService.InserirProdutos(Registro);

                    MessageBox.Show("Produto cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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



        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtMarca.Text = txtNome.Text = txtModelo.Text = txtValorCompra.Text = txtDescricao.Text = txtValorCompra.Text = txtValorVenda.Text = "";

        }

        private void txtSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
