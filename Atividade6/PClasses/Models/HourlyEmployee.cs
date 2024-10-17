using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses.Models
{
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(
            int id = 0,
            string name = "",
            DateTime companyEntryDate = default,
            double hourlySalary = 0,
            double workingHours = 0,
            int absentDays = 0
        ) : base(id, name, companyEntryDate)
        {
            this.HourlySalary = hourlySalary;
            this.WorkingHours = workingHours;
            this.AbsentDays = absentDays;
        }

        // Properties

        public double HourlySalary { get; set; }
        public double WorkingHours { get; set; }
        public int AbsentDays { get; set; }

        // Methods

        public override double WorkingTimeInDays()
        {
            DateTime today = DateTime.Today;

            double workingDays = today.Subtract(this.CompanyEntryDate).TotalDays;

            return workingDays - this.AbsentDays;
        }

        public override double GrossSalary()
        {
            return this.HourlySalary * this.WorkingHours;
        }
    }
}
