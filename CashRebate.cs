using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCashRegister
{
    class CashRebate:CashSuper
    {
        private double _moneyRebate = 0;

        public CashRebate(double moneyRebate)
        {
            this._moneyRebate = moneyRebate;
        }

        public override double CountMoney(double Money)
        {
            return Money * _moneyRebate;
        }
    }
}
