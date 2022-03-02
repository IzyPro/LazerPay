using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Models.Requests
{
    public class TransferRequest
    {
        public int amount { get; set; }
        public string recipient { get; set; }
        public string coin { get; set; }
        public string blockchain { get; set; }
    }
}
