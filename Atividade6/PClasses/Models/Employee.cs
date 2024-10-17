using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses.Models
{
    public abstract class Employee
    {
        private int _id;
        private string _name;
        private DateTime _companyEntryDate;

        public Employee(int id = 0, string name = "", DateTime companyEntryDate = default)
        {
            this._id = id;
            this._name = name;
            this._companyEntryDate = companyEntryDate;
        }

        // Properties

        public int Id
        { 
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public DateTime CompanyEntryDate
        {
            get { return this._companyEntryDate; }
            set { this._companyEntryDate = value; }
        }

        // Methods

        public virtual double WorkingTimeInDays()
        {
            DateTime today = DateTime.Today;

            return today.Subtract(this._companyEntryDate).TotalDays;
        }

        public abstract double GrossSalary();
    }
}
