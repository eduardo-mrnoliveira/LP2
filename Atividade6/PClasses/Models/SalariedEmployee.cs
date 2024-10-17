using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses.Models
{
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(
            int id = 0,
            string name = "",
            DateTime companyEntryDate = default,
            double monthlySalary = 0
        ) : base(id, name, companyEntryDate)
        {
            this.MonthlySalary = monthlySalary;
        }

        // Properties

        public Double MonthlySalary { get; set; }

        // Methods

        public override double GrossSalary()
        {
            return this.MonthlySalary;
        }
    }
}
