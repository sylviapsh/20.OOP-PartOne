using System;
using System.Text;

namespace Humans
{
    public class Worker : Human
    {
        //Fields
        private decimal weekSalary = 0;
        private decimal workHoursPerDay = 0;
        

        //Properties
        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value >= 0)
                {
                    weekSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The weekly salary cannot be less than zero!");
                }
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }
            set
            {
                if (value >= 0)
                {
                    workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The work hours per day cannot be less than zero!");
                }
            }
        }

        public decimal SalaryPerHour
        {
            get
            {
                return MoneyPerHour();
            }
        }

        //Method to calculate the money per hour salary
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = WeekSalary / (WorkHoursPerDay * 5m);

            return moneyPerHour;
        }

        //Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //ovveride ToString()
        public override string ToString()
        {
            StringBuilder workerPrint = new StringBuilder();
            workerPrint.AppendLine();
            workerPrint.AppendFormat("Name: {0} {1}", FirstName, LastName);
            workerPrint.AppendLine();
            workerPrint.AppendFormat("Weekly salary: {0} lv.", WeekSalary);
            workerPrint.AppendLine();
            workerPrint.AppendFormat("Work hours per day: {0}", WorkHoursPerDay);
            workerPrint.AppendLine();
            workerPrint.AppendFormat("Salary per hour: {0:F2} lv.", SalaryPerHour);
            workerPrint.AppendLine();

            return workerPrint.ToString();
        }
    }
}
