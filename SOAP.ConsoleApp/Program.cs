using ServiceReference;
using SOAP.ConsoleApp.Services;
using System;
using System.ServiceModel.Channels;
using System.Threading;

namespace SOAP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cl = new PaymentServiceDemoClient();
            //var res = cl.DecreaseUserBalanceAsync(new PaymentData
            //{
            //    UserId = "some_id",
            //    PaymentAmount = 300
            //}).Result;

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
