using System;
using Infra.Services;
using System.Windows.Forms;

namespace Program.Views
{
    public partial class GestaoEstoque : Form
    {
        ProgramService _programService = new ProgramService();

        public GestaoEstoque()
        {
            InitializeComponent();
        }

        private void GestaoEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvEstoque_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvEstoque.CurrentRow.Index;

            txtObservacao.Text = dgvEstoque["Observacao", sel].Value.ToString();
            txtQuantidade.Text = dgvEstoque["Quantidade", sel].Value.ToString();
        }
    }
}
