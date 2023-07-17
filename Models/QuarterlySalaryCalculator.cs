using System;


namespace injection.Models.services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        
            public double CalculateSalary(double annualSalary)
            {
                return annualSalary / 4;
            }

           
        
    }
}
