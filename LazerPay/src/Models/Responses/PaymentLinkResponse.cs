using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPayNET.Models.Responses
{
    public class PaymentLinkResponse
    {
        public string message { get; set; }
        public Data data { get; set; }
        public int statusCode { get; set; }
        public string status { get; set; }
    }
    public class GetAllPaymentLinkResponse
    {
        public string message { get; set; }
        public List<Data> data { get; set; }
        public int statusCode { get; set; }
        public string status { get; set; }
    }
    public class Data
    {
        public string id { get; set; }
        public string reference { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string? redirectUrl { get; set; }
        public string logo { get; set; }
        public string type { get; set; }
        public string network { get; set; }
        public string status { get; set; }
        public string paymentUrl { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
