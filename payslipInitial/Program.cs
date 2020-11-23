using System;

namespace payslipInitial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise
            Console.WriteLine("Welcome to the payslip generator! Get ready for the most fun you've had ever!!!");

            // Read data
            Console.Write("Please input your first name: ");
            string nameFirst = Console.ReadLine();
            Console.Write("Please input your surname: ");
            string nameLast = Console.ReadLine();
            Console.Write("Please enter your annual salary: ");
            string incomeAnnualInput = Console.ReadLine();
            Console.Write("Please enter your super rate: ");
            string rateSuper = Console.ReadLine();
            Console.Write("Please enter your payment start date: ");
            string dateStart = Console.ReadLine();
            Console.Write("Please enter your payment end date: ");
            string dateEnd = Console.ReadLine();

            // Process data
            double incomeAnnual = Double.Parse(incomeAnnualInput);
            
            string name = nameFirst + " " + nameLast;
            string payPeriod = dateStart + " - " + dateEnd;
            double incomeGross = Math.Floor(incomeAnnual / 12);
            double incomeTax = CalculateTax(incomeAnnual);
            double incomeNet = incomeGross - incomeTax;
            double super = Math.Floor(incomeGross * (Double.Parse(rateSuper) / 100));

            // Print data
            Console.WriteLine("\nYour payslip has been generated! \n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Pay Period: " + payPeriod);
            Console.WriteLine("Gross Income: " + incomeGross);
            Console.WriteLine("Income Tax: " + incomeTax);
            Console.WriteLine("Net Income: " + incomeNet);
            Console.WriteLine("Super: " + super);
            Console.WriteLine("\nThank you for using MYOB!");

        }
        static double CalculateTax(double incomeAnnual)
        {
            double incomeTax = 0.00;
            if (incomeAnnual > 18200)
            {
                incomeTax = ((incomeAnnual - 18200) * 0.19)/12;
            } 
            if (incomeAnnual > 37000)
            {
                incomeTax = (3572 + ((incomeAnnual - 37000) * 0.325))/12;
            } 
            if (incomeAnnual > 87000)
            {
                incomeTax = (19822 + ((incomeAnnual - 87000) * 0.37))/12;
            }
            if (incomeAnnual > 180000)
            {
                incomeTax = (54232 + ((incomeAnnual - 180000) * 0.45))/12;
            }

            return Math.Ceiling(incomeTax);
        }
    }
}