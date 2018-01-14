using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using ProgramacaoInternet.Domain.Abstract;
using ProgramacaoInternet.Domain.Entities;
using ProgramacaoInternet.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            //kernel.Bind<IEstacaoAnoRepository>().To<EFEstacaoAnoRepository>();
            Mock<IEstacaoAnoRepository> mock = new Mock<IEstacaoAnoRepository>();
            mock.Setup(m => m.EstacoesAno).Returns(new List<EstacaoAno> {
                    new EstacaoAno { Nome = "Verão", Observacao = "Quente" },
                    new EstacaoAno { Nome = "Inverno", Observacao = "Frio" }
            });
            kernel.Bind<IEstacaoAnoRepository>().ToConstant(mock.Object);
        }
    }
}