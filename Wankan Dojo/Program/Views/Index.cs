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

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inadiplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAlunos CadastroDeAlunos = new CadastroAlunos();
            CadastroDeAlunos.MdiParent = this;
            CadastroDeAlunos.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarAlunos AlterarAlunos = new AlterarAlunos();
            AlterarAlunos.MdiParent = this;
            AlterarAlunos.Show();
        }
    }
}
