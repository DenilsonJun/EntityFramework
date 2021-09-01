using Domain.Entity;
using Infra.EF.Contexto;
using Infra.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Views
{
    public partial class AlterarAlunos : Form
    {
        ProgramService _programService = new ProgramService();
        WankanDojoContext contexto = new WankanDojoContext();
        public AlterarAlunos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           txtEndereco.Text = txtNome.Text = txtTelefone.Text = "";
            cbGraduacao.SelectedItem = null;
        }

        private void AlterarAlunos_Load(object sender, EventArgs e)
        {
            this.CarregaDados();
        }

        public void CarregaDados()
        {
            dgvAluno.DataSource = contexto.Alunos.AsNoTracking().ToList<Alunos>();
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvAluno.CurrentRow.Index;

            txtNome.Text = dgvAluno["Nome", sel].Value.ToString();
            txtTelefone.Text = dgvAluno["Telefone", sel].Value.ToString();
            txtEndereco.Text = dgvAluno["Endereco", sel].Value.ToString();
            cbGraduacao.Text = dgvAluno["Graduacao", sel].Value.ToString();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, telefone, endereco;
            int graduacao;

            int sel = dgvAluno.CurrentRow.Index;

            nome = txtNome.Text.Trim();
            telefone = txtTelefone.Text.Trim();
            endereco = txtEndereco.Text.Trim();
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

            if (nome != "" || telefone != "" || graduacao != 0 || endereco != "")
            {
                try
                {
                    var Registro = new Alunos()
                    {
                        ID = Convert.ToInt32(dgvAluno["ID", sel].Value),
                        Nome = nome,
                        Nascimento = Convert.ToDateTime(dgvAluno["Nascimento", sel].Value),
                        Telefone = telefone,
                        Endereco = endereco,
                        Graduacao = graduacao,
                        Responsavel = Convert.ToString(dgvAluno["Responsavel", sel].Value),
                        Sexo = Convert.ToString(dgvAluno["Sexo", sel].Value),
                        Status = Convert.ToString(dgvAluno["Status",sel].Value)
                    };

                    _programService.AtualizaAlunos(Registro);

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

            this.CarregaDados();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int sel, codigo;
            sel = dgvAluno.CurrentRow.Index;
            codigo = Convert.ToInt32(dgvAluno["ID", sel].Value);



            if (codigo != 0)
            {
                try
                {
                    var Registro = new Alunos()
                    {
                        ID = codigo
                    };

                    _programService.ExcluiAluno(Registro);

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

            this.CarregaDados();
        }
    }
}
