using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripeModule.Backend
{
    public interface IPayment
    {
        public Guid Id { get; }

        /// <summary>
        /// Product/service id for which payment happened
        /// </summary>
        public Guid ProductId { get; }

        public decimal Price { get; }

        public DateTime PaymentDateTime { get; }
    }
}
