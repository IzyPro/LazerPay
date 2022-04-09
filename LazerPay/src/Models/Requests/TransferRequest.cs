using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LazerPayNET.Models.Requests
{
    public class TransferRequest
    {
        [Range(1, double.MaxValue)]
        public decimal amount { get; set; }
        public string recipient { get; set; }
        public string coin { get; set; }
        public string blockchain { get; set; }
    }
}
