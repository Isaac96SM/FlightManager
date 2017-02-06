﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace FlightManagement.InsertSale {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InsertSaleSoap", Namespace="http://tempuri.org/")]
    public partial class InsertSale : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SaleRequestOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public InsertSale() {
            this.Url = global::FlightManagement.Properties.Settings.Default.FlightManagement_net_azurewebsites_flightwebservice_InsertSale;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SaleRequestCompletedEventHandler SaleRequestCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaleRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response SaleRequest(int parRow, string parSeat, int parTravel, int parCustomer) {
            object[] results = this.Invoke("SaleRequest", new object[] {
                        parRow,
                        parSeat,
                        parTravel,
                        parCustomer});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SaleRequestAsync(int parRow, string parSeat, int parTravel, int parCustomer) {
            this.SaleRequestAsync(parRow, parSeat, parTravel, parCustomer, null);
        }
        
        /// <remarks/>
        public void SaleRequestAsync(int parRow, string parSeat, int parTravel, int parCustomer, object userState) {
            if ((this.SaleRequestOperationCompleted == null)) {
                this.SaleRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaleRequestOperationCompleted);
            }
            this.InvokeAsync("SaleRequest", new object[] {
                        parRow,
                        parSeat,
                        parTravel,
                        parCustomer}, this.SaleRequestOperationCompleted, userState);
        }
        
        private void OnSaleRequestOperationCompleted(object arg) {
            if ((this.SaleRequestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaleRequestCompleted(this, new SaleRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Response {
        
        private bool resultField;
        
        private string resultDescriptionField;
        
        /// <comentarios/>
        public bool Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <comentarios/>
        public string ResultDescription {
            get {
                return this.resultDescriptionField;
            }
            set {
                this.resultDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SaleRequestCompletedEventHandler(object sender, SaleRequestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaleRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SaleRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591