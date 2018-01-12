using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCashRegister
{
    class CashRetrun : CashSuper
    {
        private double _moneyCondition = 0.0;
        private double _moneyRetrun = 0.0;

        public CashRetrun(double moneyCondition, double moneyRetrun)
        {
            this._moneyCondition = moneyCondition;
            this._moneyRetrun = moneyRetrun;
        }
        public override double CountMoney(double Money)
        {
            double result = 0;
            if (Money >= _moneyCondition)
                result = Money - Math.Floor(Money / _moneyCondition) * _moneyRetrun;
            return result;
        }
    }
}
