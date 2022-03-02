using LazerPay.NET.src.Models.Requests;
using LazerPay.NET.src.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LazerPay.NET.src.Interfaces
{
    public interface ILazerPayInterface
    {
        Task<InitializePaymentResponse> InitializePayment(InitializePaymentRequest request);
        Task<TransferResponse> Transfer(TransferRequest request);
        Task<GetAcceptedCoinsResponse> GetAcceptedCoins();
        Task<ConfirmPaymentResponse> ConfirmPayment(string reference);
    }
}
