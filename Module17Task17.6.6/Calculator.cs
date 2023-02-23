using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17Task17._6._6
{
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}