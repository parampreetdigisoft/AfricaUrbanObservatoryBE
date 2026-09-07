using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.PaymentDto;

namespace AfricaUrbanObservatory.IServices
{
    public interface IPaymentService
    {
        Task<ResultResponseDto<CheckoutSessionResponse>> CreateCheckoutSession(CreateCheckoutSessionDto request);
        Task<ResultResponseDto<VerifySessionResponse>> VerifySession(VerifySessionDto request);
        Task<ResultResponseDto<string>> StripeWebhook();
    }
}
