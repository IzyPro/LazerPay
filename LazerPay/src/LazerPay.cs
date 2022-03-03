using LazerPayNET.Helpers;
using LazerPayNET.Interfaces;
using LazerPayNET.Models.Requests;
using LazerPayNET.Models.Responses;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LazerPayNET
{
    public class LazerPay : ILazerPayInterface
    {
        private readonly string secretKey;
        private readonly string publicKey;
        private readonly RestClient httpClient = new RestClient();

        public LazerPay(string publicKey, string secretKey)
        {
            this.secretKey = secretKey;
            this.publicKey = publicKey;
            httpClient.BaseUrl = new Uri(RouteHelper.API_BASE_URL);
            httpClient.AddDefaultHeaders(new Dictionary<string, string>()
            {
                {"x-api-key", publicKey },
                {"Authorization", secretKey },
                {"Content-Type", "application/json"},
                {"Accept", "application/json"}
            });
        }

        //INITIALIZE PAYMENT
        public async Task<InitializePaymentResponse> InitializePayment(InitializePaymentRequest request)
        {
            try
            {
                var httpRequest = new RestRequest(RouteHelper.InitializeTransactionURL, Method.POST);
                var requestBody = JsonConvert.SerializeObject(request);
                httpRequest.AddJsonBody(requestBody);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<InitializePaymentResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //CONFIRM PAYMENT
        public async Task<ConfirmPaymentResponse> ConfirmPayment(string reference)
        {
            try
            {
                var httpRequest = new RestRequest($"{RouteHelper.ConfirmTransactionURL}/{reference}", Method.GET);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<ConfirmPaymentResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //GET ACCEPTED COINS
        public async Task<GetAcceptedCoinsResponse> GetAcceptedCoins()
        {
            try
            {
                var httpRequest = new RestRequest(RouteHelper.GetAcceptedCoinsURL, Method.GET);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<GetAcceptedCoinsResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //TRANSFER(PAYOUT) TO A CRYPTO WALLET
        public async Task<TransferResponse> Transfer(TransferRequest request)
        {
            try
            {
                var httpRequest = new RestRequest(RouteHelper.TransferFundsURL, Method.POST);
                var requestBody = JsonConvert.SerializeObject(request);
                httpRequest.AddJsonBody(requestBody);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<TransferResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
