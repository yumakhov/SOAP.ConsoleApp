using ServiceReference;
using SimpleSOAPClient;
using SimpleSOAPClient.Exceptions;
using SimpleSOAPClient.Handlers;
using SimpleSOAPClient.Helpers;
using SimpleSOAPClient.Models;
using SimpleSOAPClient.Models.Headers;
using SimpleSOAPClient.Models.Headers.Oasis.Security;
using SOAP.ConsoleApp.Services;
using System;
using System.Threading;
using System.Xml.Serialization;

namespace SOAP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ct = new CancellationTokenSource().Token;
            using (var client = new SoapClientWrapper("http://localhost:8088/PaymentServiceDemo"))
            {
                var requestMessage = new IncreaseUserBalanceRequest
                {
                    PaymentData = new PaymentData
                    {
                        UserId = "some_id",
                        PaymentAmount = 300
                    }
                };
                var response = client.SendRequestAsync<IncreaseUserBalanceRequest, IncreaseUserBalanceResponse>(
                    "http://localhost:8088/PaymentServiceDemo/IncreaseUserBalance", requestMessage, ct
                    ).Result;

                
            }

            Console.ReadKey();
        }
    }
}
