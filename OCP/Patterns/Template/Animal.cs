using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Patterns.Template
{
    public abstract class Animal
    {
        protected double Height { get; set; }
        protected double Weight { get; set; }

        protected Animal(double height, double weight)
        {
            Height = height;
            Weight = weight;
        }


        public virtual double CaculateBMI()
        {
            return Weight / Math.Pow(Height, 2);
        }
    }
}
