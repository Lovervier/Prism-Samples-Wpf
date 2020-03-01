using Prism.Ioc;
using Prism.Unity;
using BootstrapperShell.Views;
using System.Windows;

namespace BootstrapperShell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //throw new System.NotImplementedException();
        }
    }
}