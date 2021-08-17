using Infra.EF.Contexto;

namespace Infra.Services
{
    public abstract class ServiceBase
    {
        public ServiceBase()
        {
            contexto = new OutletImportsContext();
        }

        public ServiceBase(OutletImportsContext Contexto)
        {
            contexto = Contexto;
        }

        protected OutletImportsContext contexto;
    }
}
