using System.Windows;

namespace PlcSimulator
{
    using Prism.Ioc;

    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App
    {
<<<<<<< HEAD
        protected override Window CreateShell() => this.Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
=======
        protected override Window CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
>>>>>>> d4fc21dc17c2bbf07daf17e4e99d1af1a9d868e0
        }
    }
}