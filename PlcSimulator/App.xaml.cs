using System.Windows;

namespace PlcSimulator
{
    using Prism.Ioc;

    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell() => this.Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
        }
    }
}