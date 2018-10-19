using Prism.Mvvm;

namespace PlcSimulator.ViewModels
{
    using Prism.Regions;

    public class MainPageViewModel : BindableBase
    {
        public string Message => "Hello world powered by Prism.Autofac.Forms";
    }
}
