using Prism.Commands;
using Prism.Mvvm;

namespace PlcSimulator
{
    public class ViewModel : BindableBase
    {
        private readonly Model model;

        public ViewModel()
        {
            this.model = new Model();
        }

        private double leftValue;
        public double LeftValue
        {
            get => this.leftValue;
            set => this.SetProperty(ref this.leftValue, value);
        }

        private double rightValue;
        public double RightValue
        {
            get => this.rightValue;
            set => this.SetProperty(ref this.rightValue, value);
        }

        private double answerValue;
        public double AnswerValue
        {
            get => this.answerValue;
            set => this.SetProperty(ref this.answerValue, value);
        }

        private DelegateCommand calcComamnd;
        public DelegateCommand CalcCommand
        {
            get
            {
                return this.calcComamnd = this.calcComamnd ?? new DelegateCommand(this.CalcExecute);
            }
        }

        private void CalcExecute()
        {
            this.AnswerValue = this.model.Calc(this.LeftValue, this.RightValue);
        }
    }
}
