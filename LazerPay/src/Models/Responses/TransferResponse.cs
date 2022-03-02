using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Models.Responses
{
    public class TransferResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public TransferData data { get; set; }
        public int statusCode { get; set; }
    }
    public class TransferData
    {
        public string id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string transactionHash { get; set; }
        public string walletAddress { get; set; }
        public string coin { get; set; }
        public int amount { get; set; }
        public string reference { get; set; }
    }
}
