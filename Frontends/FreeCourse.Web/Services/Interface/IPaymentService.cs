using FreeCourse.Web.Models.FakePayments;

namespace FreeCourse.Web.Services.Interface
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput);
    }
}
