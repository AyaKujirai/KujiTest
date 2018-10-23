using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlcSimulator
{
    public class ViewModel : BindableBase
    {
        public Model model;

        public ViewModel()
        {
            model = new Model();
        }

        private double _leftValue;
        public double LeftValue
        {
            get { return _leftValue; }
            set { this.SetProperty(ref this._leftValue, value); }
        }

        private double _rightValue;
        public double RightValue
        {
            get { return _rightValue; }
            set { this.SetProperty(ref this._rightValue, value); }
        }

        private double _answerValue;
        public double AnswerValue
        {
            get { return _answerValue; }
            set { this.SetProperty(ref this._answerValue, value); }
        }

        private DelegateCommand calcComamnd;
        public DelegateCommand CalcCommand
        {
            get { return calcComamnd = calcComamnd ?? new DelegateCommand(CalcExecute); }
        }

        private void CalcExecute()
        {
            AnswerValue = model.Calc(LeftValue, RightValue);
        }
    }
}
