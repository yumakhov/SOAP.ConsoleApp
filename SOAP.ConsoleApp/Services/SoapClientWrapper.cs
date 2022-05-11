using SimpleSOAPClient;
using SimpleSOAPClient.Exceptions;
using SimpleSOAPClient.Handlers;
using SimpleSOAPClient.Helpers;
using SimpleSOAPClient.Models;
using SimpleSOAPClient.Models.Headers;
using SimpleSOAPClient.Models.Headers.Oasis.Security;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SOAP.ConsoleApp.Services
{
    public class SoapClientWrapper: IDisposable
    {
        private readonly SoapClient _soapClient;
        private readonly string _serviceUrl;

        public SoapClientWrapper(string serviceUrl)
        {
            _serviceUrl = serviceUrl;
            _soapClient = CreateSoapClient();
        }

        private SoapClient CreateSoapClient()
        {
            return SoapClient.Prepare()
                .WithHandler(new DelegatingSoapHandler
                {
                    OnSoapEnvelopeRequestAsyncAction = async (soapClient, soapEnvelopeRequestArguments, cancellationToken) =>
                    {
                        soapEnvelopeRequestArguments.Envelope.WithHeaders(
                            KnownHeader.Oasis.Security.UsernameTokenAndPasswordText("some-user", "some-password"));
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
                });
        }

        public void Dispose()
        {
            _soapClient?.Dispose();
        }

        public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(string operationName, TRequest requestMessage, CancellationToken ct) where TRequest : class where TResponse : class, new()
        {
            var requestEnvelope = await SendSoapRequestAsync(operationName, requestMessage, ct);

            return DeserializeSoapResponseBody<TResponse>(requestEnvelope);
        }

        private async Task<SoapEnvelope> SendSoapRequestAsync<TRequest>(string operationName, TRequest requestMessage, CancellationToken ct)
        {
            try
            {
                var requestEnvelope = SoapEnvelope
                    .Prepare()
                    .Body(requestMessage);

                return await _soapClient.SendAsync(_serviceUrl, operationName, requestEnvelope, ct);
            }
            catch (SoapEnvelopeSerializationException e)
            {
                Console.WriteLine(
                    $"Failed to serialize the SOAP Envelope [Envelope={e.Envelope}]");
                throw;

            }
            catch (SoapEnvelopeDeserializationException e)
            {
                Console.WriteLine(
                    $"Failed to deserialize the response into a SOAP Envelope [XmlValue={e.XmlValue}]");
                throw;
            }
        }

        private TResponse DeserializeSoapResponseBody<TResponse>(SoapEnvelope responseEnvelope) where TResponse : class, new()
        {
            try
            {
                return responseEnvelope.Body<TResponse>();
            }
            catch (FaultException e)
            {
                Console.WriteLine(
                    $"The server returned a fault [Code={e.Code}, String={e.String}, Actor={e.Actor}]");
                throw;
            }
        }
    }
}
