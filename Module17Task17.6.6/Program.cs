using System;

namespace Module17Task17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем обычный счет
            RegularAccount regularAccount = new RegularAccount(1800.95);
            // Расчитываем ставку
            Calculator.CalculateInterest(regularAccount);

            // Создаем зарплатный счет
            SalaryAccount salaryAccount = new SalaryAccount(2500.00);
            // Расчитываем ставку
            Calculator.CalculateInterest(salaryAccount);
        }
    }
}

