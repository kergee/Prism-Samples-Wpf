using Unity;
using Prism.Unity;
using BootstrapperShell.Views;
using System.Windows;
using Prism.Ioc;

namespace BootstrapperShell
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //注册视图和视图模型的映射
            //containerRegistry.RegisterForNavigation<HomeView, HomeViewModel>();

            //注册服务接口和实现
            //containerRegistry.Register<IDataService, DataService>();

            //注册单例服务
            //containerRegistry.RegisterSingleton<ILoggerService, LoggerService>();

            //配置区域导航等
        }
    }
}
