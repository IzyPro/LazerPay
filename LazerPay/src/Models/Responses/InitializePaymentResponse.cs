using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Models.Responses
{
    public class InitializePaymentResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public PaymentData data { get; set; }
        public int statusCode { get; set; }
    }
    public class PaymentData
    {
        public string reference { get; set; }
        public string businessName { get; set; }
        public string businessEmail { get; set; }
        public string businessLogo { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string address { get; set; }
        public string coin { get; set; }
        public double cryptoAmount { get; set; }
        public string currency { get; set; }
        public int fiatAmount { get; set; }
        public double feeInCrypto { get; set; }
        public string network { get; set; }
        public bool acceptPartialPayment { get; set; }
    }
}
