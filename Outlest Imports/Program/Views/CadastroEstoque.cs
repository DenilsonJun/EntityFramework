using Infra.Services;
using System;
using System.Windows.Forms;

namespace Program.Views
{

    public partial class CadastroEstoque : Form
    {
        ProgramService _programService = new ProgramService();


        public CadastroEstoque()
        {
            InitializeComponent();
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void ControleEstoque_Load(object sender, EventArgs e)
        {


        }


        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvEstoque.CurrentRow.Index;

            txtCodigo.Text = dgvEstoque["Codigo", sel].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtQuantidade.Text = txtObs.Text = "";
        }
    }
}

