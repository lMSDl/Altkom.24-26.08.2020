using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentAccount
    {
        public float Incomes { get; set; }
        public float Outcomes { get; set; }
        public float AllowedDebit { get; set; }
        public float Balance => Incomes - Outcomes;

        public bool Charge(float amount)
        {
            if (Balance + AllowedDebit < amount)
                return false;
            Outcomes += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Incomes += amount;
        }
    }
}
