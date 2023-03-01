using FreeCourse.Web.Models.FakePayments;
using FreeCourse.Web.Services.Interface;
using System.Net.Http.Json;

namespace FreeCourse.Web.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput)
        {
            var response = await _httpClient.PostAsJsonAsync<PaymentInfoInput>("fakePayments", paymentInfoInput);

            return response.IsSuccessStatusCode;
        }
    }
}
