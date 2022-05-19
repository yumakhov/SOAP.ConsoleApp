﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8088/PaymentServiceDemo/", ConfigurationName="ServiceReference.PaymentServiceDemo")]
    public interface PaymentServiceDemo
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8088/PaymentServiceDemo/IncreaseUserBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.IncreaseUserBalanceResponse> IncreaseUserBalanceAsync(ServiceReference.IncreaseUserBalanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8088/PaymentServiceDemo/DecreaseUserBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.DecreaseUserBalanceResponse> DecreaseUserBalanceAsync(ServiceReference.DecreaseUserBalanceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost:8088/PaymentServiceDemo/")]
    public partial class PaymentData
    {
        
        private string userIdField;
        
        private int paymentAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int PaymentAmount
        {
            get
            {
                return this.paymentAmountField;
            }
            set
            {
                this.paymentAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost:8088/PaymentServiceDemo/")]
    public partial class BalanceInfo
    {
        
        private string userIdField;
        
        private int balanceAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int BalanceAmount
        {
            get
            {
                return this.balanceAmountField;
            }
            set
            {
                this.balanceAmountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IncreaseUserBalanceRequest", WrapperNamespace="http://localhost:8088/PaymentServiceDemo/", IsWrapped=true)]
    public partial class IncreaseUserBalanceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost:8088/PaymentServiceDemo/", Order=0)]
        public ServiceReference.PaymentData PaymentData;
        
        public IncreaseUserBalanceRequest()
        {
        }
        
        public IncreaseUserBalanceRequest(ServiceReference.PaymentData PaymentData)
        {
            this.PaymentData = PaymentData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserBalanceResponse", WrapperNamespace="http://localhost:8088/PaymentServiceDemo/", IsWrapped=true)]
    public partial class IncreaseUserBalanceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost:8088/PaymentServiceDemo/", Order=0)]
        public ServiceReference.BalanceInfo BalanceInfo;
        
        public IncreaseUserBalanceResponse()
        {
        }
        
        public IncreaseUserBalanceResponse(ServiceReference.BalanceInfo BalanceInfo)
        {
            this.BalanceInfo = BalanceInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DecreaseUserBalanceRequest", WrapperNamespace="http://localhost:8088/PaymentServiceDemo/", IsWrapped=true)]
    public partial class DecreaseUserBalanceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost:8088/PaymentServiceDemo/", Order=0)]
        public ServiceReference.PaymentData PaymentData;
        
        public DecreaseUserBalanceRequest()
        {
        }
        
        public DecreaseUserBalanceRequest(ServiceReference.PaymentData PaymentData)
        {
            this.PaymentData = PaymentData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserBalanceResponse", WrapperNamespace="http://localhost:8088/PaymentServiceDemo/", IsWrapped=true)]
    public partial class DecreaseUserBalanceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost:8088/PaymentServiceDemo/", Order=0)]
        public ServiceReference.BalanceInfo BalanceInfo;
        
        public DecreaseUserBalanceResponse()
        {
        }
        
        public DecreaseUserBalanceResponse(ServiceReference.BalanceInfo BalanceInfo)
        {
            this.BalanceInfo = BalanceInfo;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface PaymentServiceDemoChannel : ServiceReference.PaymentServiceDemo, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PaymentServiceDemoClient : System.ServiceModel.ClientBase<ServiceReference.PaymentServiceDemo>, ServiceReference.PaymentServiceDemo
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PaymentServiceDemoClient() : 
                base(PaymentServiceDemoClient.GetDefaultBinding(), PaymentServiceDemoClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PaymentServiceDemoSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceDemoClient(EndpointConfiguration endpointConfiguration) : 
                base(PaymentServiceDemoClient.GetBindingForEndpoint(endpointConfiguration), PaymentServiceDemoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceDemoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PaymentServiceDemoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceDemoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PaymentServiceDemoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceDemoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.IncreaseUserBalanceResponse> ServiceReference.PaymentServiceDemo.IncreaseUserBalanceAsync(ServiceReference.IncreaseUserBalanceRequest request)
        {
            return base.Channel.IncreaseUserBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.IncreaseUserBalanceResponse> IncreaseUserBalanceAsync(ServiceReference.PaymentData PaymentData)
        {
            ServiceReference.IncreaseUserBalanceRequest inValue = new ServiceReference.IncreaseUserBalanceRequest();
            inValue.PaymentData = PaymentData;
            return ((ServiceReference.PaymentServiceDemo)(this)).IncreaseUserBalanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.DecreaseUserBalanceResponse> ServiceReference.PaymentServiceDemo.DecreaseUserBalanceAsync(ServiceReference.DecreaseUserBalanceRequest request)
        {
            return base.Channel.DecreaseUserBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.DecreaseUserBalanceResponse> DecreaseUserBalanceAsync(ServiceReference.PaymentData PaymentData)
        {
            ServiceReference.DecreaseUserBalanceRequest inValue = new ServiceReference.DecreaseUserBalanceRequest();
            inValue.PaymentData = PaymentData;
            return ((ServiceReference.PaymentServiceDemo)(this)).DecreaseUserBalanceAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PaymentServiceDemoSOAP))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PaymentServiceDemoSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8088/PaymentServiceDemo");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PaymentServiceDemoClient.GetBindingForEndpoint(EndpointConfiguration.PaymentServiceDemoSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PaymentServiceDemoClient.GetEndpointAddress(EndpointConfiguration.PaymentServiceDemoSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            PaymentServiceDemoSOAP,
        }
    }
}
