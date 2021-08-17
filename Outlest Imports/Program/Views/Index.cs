using System;
using System.Windows.Forms;

namespace Program.Views
{
    public partial class Index : Form
    {
        private int childFormNumber = 0;

        public Index()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutos Produtos = new CadastroProdutos();
            Produtos.MdiParent = this;
            Produtos.Show();

        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEstoque Estoque = new CadastroEstoque();
            Estoque.MdiParent = this;
            Estoque.Show();
        }

        private void gestãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProdutos GestaoProdutos = new GestaoProdutos();
            GestaoProdutos.MdiParent = this;
            GestaoProdutos.Show();
        }

        private void gestãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoEstoque GestaoEstoque = new GestaoEstoque();
            GestaoEstoque.MdiParent = this;
            GestaoEstoque.Show();
        }
    }
}
