using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Lazer = LazerPay.NET.src;
using LazerRequests = LazerPay.NET.src.Models.Requests;
using LazerResponses = LazerPay.NET.src.Models.Responses;

namespace LazerPayTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LazerPayController : ControllerBase
    {
        private readonly Lazer.LazerPay _lazerPay;
        public LazerPayController()
        {
            _lazerPay = new Lazer.LazerPay(publicKey: "YOUR-PUBLIC-KEY-GOES-HERE", secretKey: "YOUR-SECRET-KEY-GOES-HERE");
        }

        [HttpGet("confirmPayment")]
        public async Task<LazerResponses.ConfirmPaymentResponse> ConfirmPayment(string reference)
        {
            return await _lazerPay.ConfirmPayment(reference);
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
    }
}
