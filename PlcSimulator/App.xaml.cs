using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PlcSimulator
{
    using System.Reflection;

    using Autofac;

    using Prism.Autofac;
    using Prism.Ioc;

    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            this.InitializeComponent();

            this.NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var containerUpdater = new ContainerBuilder();
            containerUpdater.RegisterAssemblyTypes(typeof(App).GetTypeInfo().Assembly)
                .Where(x => x.IsInNamespace("PlcSimulator.ViewModels")).Where(x => x.Name.EndsWith("ViewModel"))
                .AsSelf();
            containerUpdater.Update(this.Container);
            
        }
    }
}
