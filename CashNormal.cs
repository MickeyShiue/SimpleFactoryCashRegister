using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCashRegister
{
    class CashNormal:CashSuper
    {
        public override double CountMoney(double Money)
        {
            return Money;
        }
    }
}
