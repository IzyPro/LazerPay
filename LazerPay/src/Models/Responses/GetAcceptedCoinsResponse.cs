using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Models.Responses
{
    public class GetAcceptedCoinsResponse
    {
        public string message { get; set; }
        public List<CoinsData> data { get; set; }
        public string status { get; set; }
        public int statusCode { get; set; }
    }
    public class CoinsData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string logo { get; set; }
        public string address { get; set; }
        public string network { get; set; }
        public string blockchain { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
