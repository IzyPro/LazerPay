using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LazerPayNET.Models.Requests
{
    public class InitializePaymentRequest
    {
        public string reference { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string coin { get; set; }
        public string currency { get; set; }
        public string amount { get; set; }
        public bool accept_partial_payment { get; set; }
    }
}
