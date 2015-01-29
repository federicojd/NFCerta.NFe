﻿namespace NFCerta.NFe.Webservice
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Web.Services;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using Schemas.Cabecalhos;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "NfeInutilizacao2Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2")]
    public partial class NfeInutilizacao2 : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeInutilizacaoNF2OperationCompleted;

        /// <remarks/>
        public NfeInutilizacao2(string pUrl)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = pUrl;
        }

        public nfeCabecMsg nfeCabecMsgValue
        {
            get
            {
                return this.nfeCabecMsgValueField;
            }
            set
            {
                this.nfeCabecMsgValueField = value;
            }
        }

        /// <remarks/>
        public event nfeInutilizacaoNF2CompletedEventHandler nfeInutilizacaoNF2Completed;

        /// <remarks/>
        [SoapHeader("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2/nfeInutilizacaoNF2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2")]
        public System.Xml.XmlNode nfeInutilizacaoNF2([XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeInutilizacaoNF2", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeInutilizacaoNF2(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeInutilizacaoNF2", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeInutilizacaoNF2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeInutilizacaoNF2Async(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeInutilizacaoNF2Async(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeInutilizacaoNF2Async(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeInutilizacaoNF2OperationCompleted == null))
            {
                this.nfeInutilizacaoNF2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeInutilizacaoNF2OperationCompleted);
            }
            this.InvokeAsync("nfeInutilizacaoNF2", new object[] {
                    nfeDadosMsg}, this.nfeInutilizacaoNF2OperationCompleted, userState);
        }

        private void OnnfeInutilizacaoNF2OperationCompleted(object arg)
        {
            if ((this.nfeInutilizacaoNF2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeInutilizacaoNF2Completed(this, new nfeInutilizacaoNF2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void nfeInutilizacaoNF2CompletedEventHandler(object sender, nfeInutilizacaoNF2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class nfeInutilizacaoNF2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeInutilizacaoNF2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}