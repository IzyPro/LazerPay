using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LazerPayNET.Models.Requests
{
    public class CreatePaymentLinkRequest
    {
        public string title { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        public string currency { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
    }
}
