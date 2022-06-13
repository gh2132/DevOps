using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devopswebapp.Models
{
    public class Calculator
    {
        [Display( Name = "Annual Salary" )]
        public double NumberA { get; set; }

        [Display( Name = "Region Code" )]
        public double NumberB { get; set; }

        [Display( Name = "Total Tax" )]
        public double Total { get; set; }
    }

    public class Calculation
    {
        Calculator calcModel;
        public Calculation()
        {
            calcModel = new Calculator();
        }

        public double AddTwoValues(double valOne, double valTwo)
        {
            return valOne * 0.4;
        }
    }
}