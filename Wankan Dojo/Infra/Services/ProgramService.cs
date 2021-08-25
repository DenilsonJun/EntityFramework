
using Domain.Entity;
using System;

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

    }
}
