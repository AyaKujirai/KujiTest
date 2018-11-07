namespace PlcSimulator
{
    using Prism.Mvvm;

    public interface IModel
    {
        double Calc(double x, double y);
    }

    public class Model : IModel
    {
        public double Calc(double x, double y) => x + y;
    }
}
