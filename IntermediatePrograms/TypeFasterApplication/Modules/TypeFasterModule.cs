using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using TypeFaster.Interfaces;
using TypeFaster.Views;


namespace TypeFaster
{
    public class TypeFasterModule : IModule
    {
        IUnityContainer _container;
        IRegionManager _regionManager;

        public TypeFasterModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterViewsAndServices();

            //_container.Resolve<ToolbarView>();         
            var toolbarRegion = _regionManager.Regions["ToolbarRegion"];
            toolbarRegion.Add(_container.Resolve<ToolbarView>());
        }

        protected void RegisterViewsAndServices()
        {
        }



    }
}
