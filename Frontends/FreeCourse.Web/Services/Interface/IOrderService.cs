using FreeCourse.Web.Models.Orders;

namespace FreeCourse.Web.Services.Interface
{
    public interface IOrderService
    {
        /// <summary>
        /// Senkron ileitişim - direkt order mikroservisine istek yapılacak
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput); 

        /// <summary>
        /// Asenkron iletişim - sipariş bilgileri rabbitMQ'ya gönderilecek
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);

        Task<List<OrderViewModel>> GetOrder();
    }
}
