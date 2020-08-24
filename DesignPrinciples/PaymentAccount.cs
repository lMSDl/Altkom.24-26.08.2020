using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentAccount
    {
        public PaymentAccount(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Incomes { get; set; }
        public float Outcomes { get; set; }
        public float AllowedDebit { get; set; }

        public bool HasDebit()
        {
            return Incomes - Outcomes < 0;
        }
    }
}
