using FibaroTool.Modules.ModuleName;
using FibaroTool.Services;
using FibaroTool.Services.Interfaces;
using FibaroTool.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace FibaroTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
