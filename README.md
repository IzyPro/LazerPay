![LazerPay Logo](lazerpay.png)
# LazerPay
The Lazer Pay .NET SDK/Library.

This SDK allows you to initialise a payment transaction, confirm payment, get accepted coins and make transfers. 

# Get Started

## Installation
Install via .NET CLI

```
dotnet add package LazerPay.NET --version 1.1.0
```

Install via Package Manager

```
Install-Package LazerPay.NET -Version 1.1.0
```

Install via Package Reference

```
<PackageReference Include="LazerPay.NET" Version="1.1.0" />
```

Other installation methods can be found [here](https://www.nuget.org/packages/LazerPay.NET/)

## Configuration
Add namespace directive
```
using LazerPayNET;
```

Initialize
```
var lazerPay = new LazerPay(publicKey: "YOUR-PUBLIC-KEY-GOES-HERE", secretKey: "YOUR-SECRET-KEY-GOES-HERE");
```

# LazerPay Methods
[Initialize Payment](#initialize-payment)

[Confirm Payment](#confirm-payment)

[Get Accepted Coins](#get-accepted-coins)

[Transfer](#transfer)

[Create Payment Link](#create-payment-link)

[Update Payment Link](#update-payment-link)

[Get Payment Link](#get-payment-link)

[Get All Payment Link](#get-all-payment-link)

## Initialize Payment
Initializes a payment transaction and returns the address to be used in completing the payment.
```
var result = lazerPay.InitializePayment(request);
```

### Sample Request
```
{
  "reference": "string",
  "customer_name": "string",
  "customer_email": "string",
  "coin": "string",
  "currency": "string",
  "amount": "string",
  "accept_partial_payment": false
}
```

### Sample Response
```
{
  "message": "string",
  "status": "string",
  "data": {
    "reference": "string",
    "businessName": "string",
    "businessEmail": "string",
    "businessLogo": "string",
    "customerName": "string",
    "customerEmail": "string",
    "address": "string",
    "coin": "string",
    "cryptoAmount": 0,
    "currency": "string",
    "fiatAmount": 0,
    "feeInCrypto": 0,
    "network": "string",
    "acceptPartialPayment": false
  },
  "statusCode": 0
}
```


## Confirm Payment
Checks if a payment has been completed and returns a state to show the status of the payment. Payment status can either be confirmed or incomplete. A confirmed payment is a payment that the user has sent the exact amount needed to complete the transaction, if he sends less than the needed amount the transaction is in an incomplete status.
It takes an object with the address property whose value is the address returned from the initialise payment function.
```
var result = lazerPay.ConfirmPayment(reference: "TRANSACTION-REFERENCE-GOES-HERE");
```

### Sample Response
```
{
  "status": "string",
  "statusCode": 0,
  "message": "string",
  "data": {
    "id": "string",
    "reference": "string",
    "senderAddress": "string",
    "recipientAddress": "string",
    "actualAmount": 0,
    "amountPaid": "string",
    "fiatAmount": 0,
    "coin": "string",
    "currency": "string",
    "hash": "string",
    "blockNumber": "string",
    "type": "string",
    "acceptPartialPayment": true,
    "status": "string",
    "network": "string",
    "blockchain": "string",
    "customer": {
      "id": "string",
      "customerName": "string",
      "customerEmail": "string",
      "customerPhone": "string",
      "network": "string"
    },
    "feeInCrypto": 0
  }
}
```


## Get Accepted Coins
Gets the list of coins supported by Lazerpay. Using a mainnet API key returns accepted coins on the mainnet and using a testnet API key returns the accepted coins on the testnet.
```
var result = lazerPay.GetAcceptedCoins();
```

### Sample Response
```
{
  "message": "string",
  "data": [
    {
      "id": "string",
      "name": "string",
      "symbol": "string",
      "logo": "string",
      "address": "string",
      "network": "string",
      "blockchain": "string",
      "status": "string",
      "createdAt": "2022-03-03T08:10:38.122Z",
      "updatedAt": "2022-03-03T08:10:38.122Z"
    }
  ],
  "status": "string",
  "statusCode": 0
}
```

## Transfer
Transfers crypto amount from businesses lazerpay balance to external crypto wallet
```
var result = lazerPay.Transfer(request);
```

### Sample Request
```
{
  "amount": 0,
  "recipient": "string",
  "coin": "string",
  "blockchain": "string"
}
```

### Sample Response
```
{
  "message": "string",
  "status": "string",
  "data": {
    "id": "string",
    "createdAt": "2022-03-03T08:11:31.991Z",
    "updatedAt": "2022-03-03T08:11:31.991Z",
    "transactionHash": "string",
    "walletAddress": "string",
    "coin": "string",
    "amount": 0,
    "reference": "string"
  },
  "statusCode": 0
}
```


## Create Payment Link
With Payment Links, you can create a payment page and share a link to it with your customers
```
var result = lazerPay.CreatePaymentLink(request);
```

### Sample Request
```
{
  "title": "string",
  "description": "string",
  "logo": "string",
  "currency": "string",
  "type": "string",
  "amount": 0
}
```

### Sample Response
```
{
  "message": "string",
  "data": {
    "id": "string",
    "reference": "string",
    "title": "string",
    "description": "string",
    "amount": "string",
    "currency": "string",
    "redirectUrl": "string",
    "logo": "string",
    "type": "string",
    "network": "string",
    "status": "string",
    "paymentUrl": "string",
    "createdAt": "2022-04-09T17:49:49.233Z",
    "updatedAt": "2022-04-09T17:49:49.233Z"
  },
  "statusCode": 0,
  "status": "string"
}
```


## Update Payment Link
With Payment Links, you can create a payment page and share a link to it with your customers
```
var result = lazerPay.UpdatePaymentLink(reference: reference, status: status);
```

### Sample Response
```
{
  "message": "string",
  "data": {
    "id": "string",
    "reference": "string",
    "title": "string",
    "description": "string",
    "amount": "string",
    "currency": "string",
    "redirectUrl": "string",
    "logo": "string",
    "type": "string",
    "network": "string",
    "status": "string",
    "paymentUrl": "string",
    "createdAt": "2022-04-09T17:49:49.233Z",
    "updatedAt": "2022-04-09T17:49:49.233Z"
  },
  "statusCode": 0,
  "status": "string"
}
```

## Get Payment Link
With Payment Links, you can create a payment page and share a link to it with your customers
```
var result = lazerPay.GetPaymentLink(reference);
```

### Sample Response
```
{
  "message": "string",
  "data": {
    "id": "string",
    "reference": "string",
    "title": "string",
    "description": "string",
    "amount": "string",
    "currency": "string",
    "redirectUrl": "string",
    "logo": "string",
    "type": "string",
    "network": "string",
    "status": "string",
    "paymentUrl": "string",
    "createdAt": "2022-04-09T17:49:49.233Z",
    "updatedAt": "2022-04-09T17:49:49.233Z"
  },
  "statusCode": 0,
  "status": "string"
}
```

## Get All Payment Link
With Payment Links, you can create a payment page and share a link to it with your customers
```
var result = lazerPay.GetAllPaymentLink();
```

### Sample Response
```
{
  "message": "string",
  "data": [
    {
      "id": "string",
      "reference": "string",
      "title": "string",
      "description": "string",
      "amount": "string",
      "currency": "string",
      "redirectUrl": "string",
      "logo": "string",
      "type": "string",
      "network": "string",
      "status": "string",
      "paymentUrl": "string",
      "createdAt": "2022-04-09T17:52:35.350Z",
      "updatedAt": "2022-04-09T17:52:35.350Z"
    }
  ],
  "statusCode": 0,
  "status": "string"
}
```

# Foot Note
For more information, refer to the official [LazerPay](https://docs.lazerpay.finance/home/) documentation
