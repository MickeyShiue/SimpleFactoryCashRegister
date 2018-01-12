using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCashRegister
{
    class CashFactory
    {
        public static CashSuper CreateClass(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "Normal":
                    cs = new CashNormal();
                    break;
                case "Over300toSend100":
                    cs = new CashRetrun(300, 100);
                    break;
                case "Over500toSend200":
                    cs = new CashRetrun(500, 200);
                    break;
                case "Discount":
                    cs = new CashRebate(0.8);
                        break;
            }
            return cs;
        }
    } 
}
