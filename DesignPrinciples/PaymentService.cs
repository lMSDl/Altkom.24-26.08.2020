using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public PaymentAccount FindAccountById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public bool Charge(int id, float amount)
        {
            PaymentAccount customer = FindAccountById(id);
            if (customer == null)
            {
                return false;
            }

            if (GetBalance(id) + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcomes += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            PaymentAccount customer = FindAccountById(id);
            if (customer == null)
            {
                return;
            }

            customer.Incomes += amount;
        }

        public float? GetBalance(int id)
        {
            PaymentAccount customer = FindAccountById(id);
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
