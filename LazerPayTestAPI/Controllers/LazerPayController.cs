using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LazerPayNET;
using LazerRequests = LazerPayNET.Models.Requests;
using LazerResponses = LazerPayNET.Models.Responses;

namespace LazerPayTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LazerPayController : ControllerBase
    {
        private readonly LazerPay _lazerPay;
        public LazerPayController()
        {
            //_lazerPay = new LazerPay(publicKey: "YOUR-PUBLIC-KEY-GOES-HERE", secretKey: "YOUR-SECRET-KEY-GOES-HERE");
            _lazerPay = new LazerPay(publicKey: "pk_test_wyoEpd21MjelhZ5fMtDYyV9DlTBmlxYCD9G7RspFw8Nk7GEsts", secretKey: "sk_test_G2Gr3DdUpK9P7ZLzlhgExNiQVjs7XPuNnAN5JTiBXuIhlaUPJN");
        }

        [HttpGet("confirmPayment")]
        public async Task<LazerResponses.ConfirmPaymentResponse> ConfirmPayment(string reference)
        {
            return await _lazerPay.ConfirmPayment(reference: reference);
        }

        [HttpPost("initializePayment")]
        public async Task<LazerResponses.InitializePaymentResponse> InitializePayment(LazerRequests.InitializePaymentRequest request)
        {
            return await _lazerPay.InitializePayment(request);
        }

        [HttpGet]
        [Route("getAcceptedCoins")]
        public async Task<LazerResponses.GetAcceptedCoinsResponse> GetAcceptedCoins()
        {
            return await _lazerPay.GetAcceptedCoins();
        }

        [HttpPost]
        [Route("transfer")]
        public async Task<LazerResponses.TransferResponse> Transfer(LazerRequests.TransferRequest request)
        {
            return await _lazerPay.Transfer(request);
        }

        [HttpPost]
        [Route("createPaymentLink")]
        public async Task<LazerResponses.PaymentLinkResponse> CreatePaymentLink(LazerRequests.CreatePaymentLinkRequest request)
        {
            return await _lazerPay.CreatePaymentLink(request);
        }
        [HttpPut]
        [Route("updatePaymentLink")]
        public async Task<LazerResponses.PaymentLinkResponse> UpdatePaymentLink(string reference, string status)
        {
            return await _lazerPay.UpdatePaymentLink(reference: reference, status: status);
        }
        [HttpGet]
        [Route("getPaymentLink")]
        public async Task<LazerResponses.PaymentLinkResponse> GetPaymentLink(string reference)
        {
            return await _lazerPay.GetPaymentLink(reference);
        }
        [HttpGet]
        [Route("getAllPaymentLink")]
        public async Task<LazerResponses.GetAllPaymentLinkResponse> GetAllPaymentLink()
        {
            return await _lazerPay.GetAllPaymentLink();
        }
    }
}
