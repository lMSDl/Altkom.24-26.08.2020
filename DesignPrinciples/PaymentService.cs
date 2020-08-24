using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount paymentAccount, float amount)
        {
            if (paymentAccount == null)
            {
                return false;
            }
            return paymentAccount.Charge(amount);
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            if (paymentAccount == null)
            {
                return;
            }

            paymentAccount.Fund(amount);
        }
    }
}
