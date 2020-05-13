using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;
using TypeFaster;

namespace TypeFasterApp
{
    public class BootStrapper: UnityBootstrapper
    {
       
        protected override DependencyObject CreateShell()
        {
            try
            {
                return Container.TryResolve<Shell>();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }
        
        

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(TypeFaster.TypeFasterModule));
            return catalog;

            //return new DirectoryModuleCatalog()
           // {
             //   ModulePath = @".\Modules"
            //};
        }


        //protected override void ConfigureModuleCatalog()//This is another way of loading Modules
        //{

        //    Type ModuleItemsType = typeof(TypeFasterModule);
        //    ModuleCatalog.AddModule(new ModuleInfo()
        //    {
        //        ModuleName = ModuleItemsType.Name,
        //        ModuleType = ModuleItemsType.AssemblyQualifiedName,
        //        InitializationMode = InitializationMode.WhenAvailable
        //    });
        //}
    }
}
