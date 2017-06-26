[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Sistema.Apresentacao.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Sistema.Apresentacao.App_Start.NinjectWebCommon), "Stop")]

namespace Sistema.Apresentacao.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using Sistema.Aplicacao.Contratos;
    using Sistema.Aplicacao.Servicos;
    using Dominio.Contratos.Repositorios;
    using Dominio.Contratos.Servicos;
    using Dominio.Servicos;
    using InfraEstrutura.Repositorios;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //NIVEL - CAMADA DE APLICACAO
            kernel.Bind(typeof(IAplicacaoServicoGenerico<>)).To(typeof(AplicacaoServicoGenerico<>));
            kernel.Bind<IAplicacaoServicoComputador>().To<AplicacaoServicoComputador>();
            kernel.Bind<IAplicacaoServicoFonte>().To<AplicacaoServicoFonte>();
            kernel.Bind<IAplicacaoServicoHD>().To<AplicacaoServicoHD>();
            kernel.Bind<IAplicacaoServicoMemoriaRAM>().To<AplicacaoServicoMemoriaRAM>();
            kernel.Bind<IAplicacaoServicoPlacaMae>().To<AplicacaoServicoPlacaMae>();
            kernel.Bind<IAplicacaoServicoProcessador>().To<AplicacaoServicoProcessador>();

            //NIVEL - CAMADA DE DOMINIO
            kernel.Bind(typeof(IServicoGenerico<>)).To(typeof(ServicoGenerico<>));
            kernel.Bind<IServicoComputador>().To<ServicoComputador>();
            kernel.Bind<IServicoFonte>().To<ServicoFonte>();
            kernel.Bind<IServicoHD>().To<ServicoHD>();
            kernel.Bind<IServicoMemoriaRAM>().To<ServicoMemoriaRAM>();
            kernel.Bind<IServicoPlacaMae>().To<ServicoPlacaMae>();
            kernel.Bind<IServicoProcessador>().To<ServicoProcessador>();

            //NIVEL - CAMADA DE INFRA ESTRUTURA
            kernel.Bind(typeof(IRepositorioGenerico<>)).To(typeof(RepositorioGenerico<>));
            kernel.Bind<IRepositorioComputador>().To<RepositorioComputador>();
            kernel.Bind<IRepositorioFonte>().To<RepositorioFonte>();
            kernel.Bind<IRepositorioHD>().To<RepositorioHD>();
            kernel.Bind<IRepositorioMemoriaRAM>().To<RepositorioMemoriaRAM>();
            kernel.Bind<IRepositorioPlacaMae>().To<RepositorioPlacaMae>();
            kernel.Bind<IRepositorioProcessador>().To<RepositorioProcessador>();
        }        
    }
}
