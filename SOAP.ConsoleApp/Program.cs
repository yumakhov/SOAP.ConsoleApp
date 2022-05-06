using ServiceReference;
using SimpleSOAPClient;
using SimpleSOAPClient.Exceptions;
using SimpleSOAPClient.Handlers;
using SimpleSOAPClient.Helpers;
using SimpleSOAPClient.Models;
using SimpleSOAPClient.Models.Headers;
using SimpleSOAPClient.Models.Headers.Oasis.Security;
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
            using (var client = PrepareSoapClient())
            {
                var requestEnvelope = SoapEnvelope
                    .Prepare()
                    .Body(new DecreaseUserBalanceRequest
                    {
                        PaymentData = new PaymentData
                        {
                            UserId = "some_ID",
                            PaymentAmount = 343
                        }
                    })
                    ;

                SoapEnvelope responseEnvelope = null;
                try
                {
                    responseEnvelope = client.SendAsync(
                            "http://localhost:8088/PaymentServiceDemo",
                            "http://localhost:8088/PaymentServiceDemo/DecreaseUserBalance",
                            requestEnvelope, ct).Result;
                }
                catch (SoapEnvelopeSerializationException e)
                {
                    Console.WriteLine(
                        $"Failed to serialize the SOAP Envelope [Envelope={e.Envelope}]");
                    return;
                    
                }
                catch (SoapEnvelopeDeserializationException e)
                {
                    Console.WriteLine(
                        $"Failed to deserialize the response into a SOAP Envelope [XmlValue={e.XmlValue}]");
                    return;
                }

                try
                {
                    var response = responseEnvelope.Body<DecreaseUserBalanceResponse>();
                }
                catch (FaultException e)
                {
                    Console.WriteLine(
                        $"The server returned a fault [Code={e.Code}, String={e.String}, Actor={e.Actor}]");
                    return;
                }
            }

            Console.ReadKey();
        }

        private static SoapClient PrepareSoapClient()
        {
            return SoapClient.Prepare()
                .WithHandler(new DelegatingSoapHandler 
                {
                    OnSoapEnvelopeRequestAsyncAction = async (soapClient, soapEnvelopeRequestArguments, cancellationToken) =>
                    {
                        //soapEnvelopeRequestArguments.Envelope.WithHeaders(
                        //    KnownHeader.Oasis.Security.UsernameTokenAndPasswordText("some-user", "some-password"));
                    },
                    OnHttpRequestAsyncAction = async (soapClient, httpRequestArguments, cancellationToken) =>
                    {
                        var requestMethod = httpRequestArguments.Request.Method;
                        var requestUrl = httpRequestArguments.Url;
                        var requestAction = httpRequestArguments.Action;
                        var requestContent = await httpRequestArguments.Request.Content.ReadAsStringAsync();
                    },
                    OnHttpResponseAsyncAction = async (soapClient, httpResponseArguments, cancellationToken) =>
                    {
                        var responseUrl = httpResponseArguments.Url;
                        var responseAction = httpResponseArguments.Action;
                        var responseStatusCode = httpResponseArguments.Response.StatusCode;
                        var responseContent = await httpResponseArguments.Response.Content.ReadAsStringAsync();
                    },
                    OnSoapEnvelopeResponseAsyncAction = async (soapClient, soapEnvelopeResponseArguments, cancellationToken) =>
                    {
                        var header = soapEnvelopeResponseArguments.Envelope.Header<UsernameTokenAndPasswordTextSoapHeader>(
                                "{" + Constant.Namespace.OrgOpenOasisDocsWss200401Oasis200401WssWssecuritySecext10 +
                                "}Security");                        
                    }
                })
                .UsingSettings(new SoapClientSettings
                {

                });
        }
    }
}
