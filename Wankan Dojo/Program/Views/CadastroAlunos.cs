using Domain.Entity;
using Infra.EF.Contexto;
using Infra.Services;
using System;
using System.Windows.Forms;

namespace Program.Views
{
    public partial class CadastroAlunos : Form
    {
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        ProgramService _programService = new ProgramService();

        WankanDojoContext contexto = new WankanDojoContext();


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroAlunos_Load(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, responsavel, endereco, telefone, sexo;
            int graduacao;
            DateTime nascimento;

            nome = txtNome.Text.Trim();
            endereco = txtEndereco.Text.Trim();
            responsavel = txtResponsavel.Text.Trim();
            nascimento = dtpNascimento.Value;
            telefone = txtTelefone.Text.Trim();

            sexo = "";
            if (cbSexo.Text == "Feminino")
            {
                sexo = "F";              
                    
            }
            if (cbSexo.Text == "Masculino")
            {
                sexo = "M";

            }

            graduacao = 0;
            switch (cbGraduacao.Text)
            {
                case "Marrom 1 Kyu":
                    graduacao = 1;
                    break;

                case "Marrom 2 Kyu":
                graduacao = 2;
                break;


                case "Marrom 3 Kyu":
                    graduacao = 3;
                    break;

                case "Azul Escuro":
                    graduacao = 4;
                    break;

                case "Roxa":
                    graduacao = 5;
                    break;

                case "Azul Claro":
                    graduacao = 6;
                    break;

                case "Verde":
                    graduacao = 7;
                    break;

                case "Laranja":
                    graduacao = 8;
                    break;

                case "Amarela":
                    graduacao = 9;
                    break;

                case "Branca":
                    graduacao = 10;
                    break;

                case "Preta 1 DAN":
                    graduacao = 101;
                    break;

                case "Preta 2 DAN":
                    graduacao = 102;
                    break;

                case "Preta 3 DAN":
                    graduacao = 103;
                    break;

                case "Preta 4 DAN":
                    graduacao = 104;
                    break;

                case "Preta 5 DAN":
                    graduacao = 105;
                    break;

                case "Preta 6 DAN":
                    graduacao = 106;
                    break;

                case "Preta 7 DAN":
                    graduacao = 107;
                    break;

                case "Preta 8 DAN":
                    graduacao = 108;
                    break;

                case "Preta 9 DAN":
                    graduacao = 109;
                    break;
            }


            
            if (nome != "" || endereco != "" || sexo != "" || graduacao != 0 || telefone != "")
            {
                try
                    {
                    var Registro = new Alunos()
                    {
                        Nome = nome,
                        Endereco = endereco,
                        Responsavel = responsavel,
                        Sexo = sexo,
                        Graduacao = graduacao,
                        Nascimento = nascimento,
                        Telefone = telefone,
                        Status = "A"
                    };

                    _programService.InserirAlunos(Registro);
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + String.Format(ex.Message), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos Obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            txtEndereco.Text = txtNome.Text = txtResponsavel.Text = txtTelefone.Text = "";
            cbGraduacao.SelectedItem = cbSexo.SelectedItem = null;
            dtpNascimento.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
     
        }
    }
}
