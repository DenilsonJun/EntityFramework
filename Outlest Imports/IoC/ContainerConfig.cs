using Autofac;
using Domain.Interface;
using Infra.EF.Contexto;
using Infra.Services;

namespace IoC
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder _containerBuilder = CreateBuilder();
            return _containerBuilder.Build();
        }

        public static ContainerBuilder CreateBuilder()
        {
            ContainerBuilder _containerBuilder = new ContainerBuilder();

            //Repositorio
            _containerBuilder.RegisterType<OutletImportsContext>().AsSelf();

            //Servicos Repositorio
            _containerBuilder.RegisterType<ProgramService>().As<IProgramService>();

            return _containerBuilder;

        }
    }
}
