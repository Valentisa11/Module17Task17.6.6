using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17Task17._6._6
{
    public interface IAccount
    {
        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest();
    }
}