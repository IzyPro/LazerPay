﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LazerPay.NET.src.Helpers
{
    public static class RouteHelper
    {
        public static string API_BASE_URL = "https://api.lazerpay.engineering/api/v1";

        public static string InitializeTransactionURL = "/transaction/initialize";
        public static string ConfirmTransactionURL = "/transaction/verify";
        public static string GetAcceptedCoinsURL = "/coins";
        public static string TransferFundsURL = "/transfer";
    }
}