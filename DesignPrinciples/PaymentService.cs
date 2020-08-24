using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            if (customer == null)
            {
                return false;
            }
            return customer.PaymentAccount.Charge(amount);
        }

        public void Fund(Customer customer, float amount)
        {
            if (customer == null)
            {
                return;
            }

            customer.PaymentAccount.Fund(amount);
        }
    }
}
