using LazerPayNET.Models.Requests;
using LazerPayNET.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LazerPayNET.Interfaces
{
    public interface ILazerPayInterface
    {
        Task<InitializePaymentResponse> InitializePayment(InitializePaymentRequest request);
        Task<TransferResponse> Transfer(TransferRequest request);
        Task<GetAcceptedCoinsResponse> GetAcceptedCoins();
        Task<ConfirmPaymentResponse> ConfirmPayment(string reference);
        Task<PaymentLinkResponse> CreatePaymentLink(CreatePaymentLinkRequest request);
        Task<PaymentLinkResponse> UpdatePaymentLink(string reference, string status);
        Task<PaymentLinkResponse> GetPaymentLink(string reference);
        Task<GetAllPaymentLinkResponse> GetAllPaymentLink();
    }
}
