using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private IProductService _productService;
        private ICartService _cartService;
        private IPaymentService _paymentService;

        public OrderFacade(IProductService productService, ICartService cartService, IPaymentService paymentService)
        {
            _productService = productService;
            _cartService = cartService;
            _paymentService = paymentService;
        }

        public void Order(int[] productIds, int cartId)
        {
            foreach (var productId in productIds)
            {
                _cartService.AddProduct(productId, _productService.GetPrice(productId));
            }

            _paymentService.Pay(cartId, _cartService.GetPrice(cartId));
        }
    }
}
