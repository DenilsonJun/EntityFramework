using Infra.EF.Contexto;

namespace Infra.Services
{
    public abstract class ServiceBase
    {
        public ServiceBase()
        {
            contexto = new WankanDojoContext();
        }

        public ServiceBase(WankanDojoContext Contexto)
        {
            contexto = Contexto;
        }

        protected WankanDojoContext contexto;
    }
}
