
using Domain.Entity;
using System;
using System.Linq;

namespace Infra.Services
{
    public class ProgramService : ServiceBase
    {
        public int InserirAlunos(Alunos Registro)
        {
            try
            {
                contexto.Set<Alunos>().Add(Registro);

                contexto.SaveChanges();

                return Registro.ID;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public int AtualizaAlunos(Alunos Registro)
        {
            try
            {
                var AlunoAtual = contexto.Alunos.SingleOrDefault(t => t.ID == Registro.ID);

                contexto.Entry(AlunoAtual).CurrentValues.SetValues(Registro);
                contexto.SaveChanges();
                return Registro.ID;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluiAluno(Alunos Registro)
        {
            try
            {
                var Aluno = contexto.Alunos.SingleOrDefault(t => t.ID == Registro.ID);

                contexto.Set<Alunos>().Remove(Aluno);
                contexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
