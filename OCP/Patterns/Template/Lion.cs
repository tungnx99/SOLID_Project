using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Patterns.Template
{
    public class Lion : Animal
    {
        public Lion(double height, double weight) : base(height, weight)
        {
        }

        public override double CaculateBMI()
        {
            return base.CaculateBMI() * 80 / 100;
        }
    }
}
