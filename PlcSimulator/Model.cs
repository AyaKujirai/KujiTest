<<<<<<< HEAD
﻿namespace PlcSimulator
{
    using Prism.Mvvm;

    public interface IModel
    {
        double Calc(double x, double y);
    }

    public class Model : IModel
    {
        public double Calc(double x, double y) => x + y;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcSimulator
{
    public class Model
    {
        public double Calc(double x, double y)
        {
            return x + y;
        }
>>>>>>> d4fc21dc17c2bbf07daf17e4e99d1af1a9d868e0
    }
}
