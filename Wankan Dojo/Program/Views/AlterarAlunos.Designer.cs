
namespace Program.Views
{
    partial class AlterarAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.cbGraduacao = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(28, 44);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(570, 254);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellContentClick);
            // 
            // cbGraduacao
            // 
            this.cbGraduacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGraduacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGraduacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGraduacao.FormattingEnabled = true;
            this.cbGraduacao.Items.AddRange(new object[] {
            "Marrom 1 Kyu",
            "Marrom 2 Kyu",
            "Marrom 3 Kyu",
            "Azul Escuro",
            "Roxa",
            "Azul Claro",
            "Verde",
            "Laranja",
            "Amarela",
            "Branca",
            "Preta 1 DAN",
            "Preta 2 DAN",
            "Preta 3 DAN",
            "Preta 4 DAN",
            "Preta 5 DAN",
            "Preta 6 DAN",
            "Preta 7 DAN",
            "Preta 8 DAN",
            "Preta 9 DAN"});
            this.cbGraduacao.Location = new System.Drawing.Point(136, 385);
            this.cbGraduacao.Name = "cbGraduacao";
            this.cbGraduacao.Size = new System.Drawing.Size(462, 21);
            this.cbGraduacao.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(136, 359);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(462, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(136, 333);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(462, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 307);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(462, 20);
            this.txtNome.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(56, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gradução";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(58, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(65, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome Completo";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(68, 459);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(348, 459);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(476, 459);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(209, 459);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // AlterarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(647, 541);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGraduacao);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvAluno);
            this.MaximizeBox = false;
            this.Name = "AlterarAlunos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Aluno";
            this.Load += new System.EventHandler(this.AlterarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.ComboBox cbGraduacao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
    }
}