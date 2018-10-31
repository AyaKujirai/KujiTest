using Prism.Commands;
using Prism.Mvvm;

namespace PlcSimulator
{
    using System.Windows.Input;

    public class MainWindowViewModel : BindableBase
    {
        private readonly Model model;

        private double leftValue;

        private double rightValue;

        private double answerValue;

        public MainWindowViewModel()
        {
            this.model = new Model();
            this.CalcCommand = new DelegateCommand(this.CalcExecute);
        }

        public double LeftValue
        {
            get => this.leftValue;
            set => this.SetProperty(ref this.leftValue, value);
        }

        public double RightValue
        {
            get => this.rightValue;
            set => this.SetProperty(ref this.rightValue, value);
        }

        public double AnswerValue
        {
            get => this.answerValue;
            set => this.SetProperty(ref this.answerValue, value);
        }

        public ICommand CalcCommand { get; set; }

        private bool CanCalcExecute() => true;

        private void CalcExecute() => this.AnswerValue = this.model.Calc(this.LeftValue, this.RightValue);
    }
}
