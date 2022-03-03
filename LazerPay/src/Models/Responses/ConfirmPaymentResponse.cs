using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Models.Responses
{
    public class ConfirmPaymentResponse
    {
        public string status { get; set; }
        public int statusCode { get; set; }
        public string message { get; set; }
        public ConfirmPaymentData data { get; set; }
    }
    public class Customer
    {
        public string id { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public object customerPhone { get; set; }
        public string network { get; set; }
    }

    public class ConfirmPaymentData
    {
        public string id { get; set; }
        public string reference { get; set; }
        public object senderAddress { get; set; }
        public string recipientAddress { get; set; }
        public int actualAmount { get; set; }
        public object amountPaid { get; set; }
        public int fiatAmount { get; set; }
        public string coin { get; set; }
        public string currency { get; set; }
        public object hash { get; set; }
        public object blockNumber { get; set; }
        public string type { get; set; }
        public bool acceptPartialPayment { get; set; }
        public string status { get; set; }
        public string network { get; set; }
        public string blockchain { get; set; }
        public Customer customer { get; set; }
        public int feeInCrypto { get; set; }
    }
}
