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
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
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
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<ConfirmPaymentResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //CREATE PAYMENT LINK
        public async Task<PaymentLinkResponse> CreatePaymentLink(CreatePaymentLinkRequest request)
        {
            try
            {
                var httpRequest = new RestRequest(RouteHelper.PaymentLinkURL, Method.POST);
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
                var requestBody = JsonConvert.SerializeObject(request);
                httpRequest.AddJsonBody(requestBody);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<PaymentLinkResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //UPDATE PAYMENT LINK
        public async Task<PaymentLinkResponse> UpdatePaymentLink(string reference, string status)
        {
            try
            {
                var obj = new
                {
                    status = status,
                };
                var httpRequest = new RestRequest($"{RouteHelper.PaymentLinkURL}/{reference}", Method.PUT);
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
                var requestBody = JsonConvert.SerializeObject(obj);
                httpRequest.AddJsonBody(requestBody);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<PaymentLinkResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET PAYMENT LINK
        public async Task<PaymentLinkResponse> GetPaymentLink(string reference)
        {
            try
            {
                var httpRequest = new RestRequest($"{RouteHelper.PaymentLinkURL}/{reference}", Method.GET);
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<PaymentLinkResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET ALL PAYMENT LINK
        public async Task<GetAllPaymentLinkResponse> GetAllPaymentLink()
        {
            try
            {
                var httpRequest = new RestRequest(RouteHelper.PaymentLinkURL, Method.GET);
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
                IRestResponse response = await httpClient.ExecuteAsync(httpRequest);
                return JsonConvert.DeserializeObject<GetAllPaymentLinkResponse>(ResponseHelper.ProcessResponse(response));
            }
            catch (Exception ex)
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
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
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
                httpRequest.AddHeader("Authorization", "Bearer " + secretKey);
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
