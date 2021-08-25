using System;

namespace Domain.Entity
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }
        public int Graduacao { get; set; }
        public string Status { get; set; }

    }
}
