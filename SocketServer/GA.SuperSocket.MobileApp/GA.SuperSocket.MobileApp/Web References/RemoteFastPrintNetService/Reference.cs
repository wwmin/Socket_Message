﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace GA.SuperSocket.MobileApp.RemoteFastPrintNetService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FastPrintNetServiceSoap", Namespace="http://tempuri.org/")]
    public partial class FastPrintNetService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetServiceRunStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOnlineClientsInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOnlineClientsTotalCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FastPrintNetService() {
            this.Url = global::GA.SuperSocket.MobileApp.Properties.Settings.Default.GA_SuperSocket_MobileApp_RemoteFastPrintNetService_FastPrintNetService;
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
        public event GetServiceRunStatusCompletedEventHandler GetServiceRunStatusCompleted;
        
        /// <remarks/>
        public event GetOnlineClientsInfoCompletedEventHandler GetOnlineClientsInfoCompleted;
        
        /// <remarks/>
        public event GetOnlineClientsTotalCountCompletedEventHandler GetOnlineClientsTotalCountCompleted;
        
        /// <remarks/>
        public event SendMessageCompletedEventHandler SendMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetServiceRunStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetServiceRunStatus() {
            object[] results = this.Invoke("GetServiceRunStatus", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetServiceRunStatusAsync() {
            this.GetServiceRunStatusAsync(null);
        }
        
        /// <remarks/>
        public void GetServiceRunStatusAsync(object userState) {
            if ((this.GetServiceRunStatusOperationCompleted == null)) {
                this.GetServiceRunStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceRunStatusOperationCompleted);
            }
            this.InvokeAsync("GetServiceRunStatus", new object[0], this.GetServiceRunStatusOperationCompleted, userState);
        }
        
        private void OnGetServiceRunStatusOperationCompleted(object arg) {
            if ((this.GetServiceRunStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceRunStatusCompleted(this, new GetServiceRunStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetOnlineClientsInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OnlineClient[] GetOnlineClientsInfo() {
            object[] results = this.Invoke("GetOnlineClientsInfo", new object[0]);
            return ((OnlineClient[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOnlineClientsInfoAsync() {
            this.GetOnlineClientsInfoAsync(null);
        }
        
        /// <remarks/>
        public void GetOnlineClientsInfoAsync(object userState) {
            if ((this.GetOnlineClientsInfoOperationCompleted == null)) {
                this.GetOnlineClientsInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOnlineClientsInfoOperationCompleted);
            }
            this.InvokeAsync("GetOnlineClientsInfo", new object[0], this.GetOnlineClientsInfoOperationCompleted, userState);
        }
        
        private void OnGetOnlineClientsInfoOperationCompleted(object arg) {
            if ((this.GetOnlineClientsInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOnlineClientsInfoCompleted(this, new GetOnlineClientsInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetOnlineClientsTotalCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetOnlineClientsTotalCount() {
            object[] results = this.Invoke("GetOnlineClientsTotalCount", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetOnlineClientsTotalCountAsync() {
            this.GetOnlineClientsTotalCountAsync(null);
        }
        
        /// <remarks/>
        public void GetOnlineClientsTotalCountAsync(object userState) {
            if ((this.GetOnlineClientsTotalCountOperationCompleted == null)) {
                this.GetOnlineClientsTotalCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOnlineClientsTotalCountOperationCompleted);
            }
            this.InvokeAsync("GetOnlineClientsTotalCount", new object[0], this.GetOnlineClientsTotalCountOperationCompleted, userState);
        }
        
        private void OnGetOnlineClientsTotalCountOperationCompleted(object arg) {
            if ((this.GetOnlineClientsTotalCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOnlineClientsTotalCountCompleted(this, new GetOnlineClientsTotalCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ResponseResult SendMessage(string userId, string data) {
            object[] results = this.Invoke("SendMessage", new object[] {
                        userId,
                        data});
            return ((ResponseResult)(results[0]));
        }
        
        /// <remarks/>
        public void SendMessageAsync(string userId, string data) {
            this.SendMessageAsync(userId, data, null);
        }
        
        /// <remarks/>
        public void SendMessageAsync(string userId, string data, object userState) {
            if ((this.SendMessageOperationCompleted == null)) {
                this.SendMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMessageOperationCompleted);
            }
            this.InvokeAsync("SendMessage", new object[] {
                        userId,
                        data}, this.SendMessageOperationCompleted, userState);
        }
        
        private void OnSendMessageOperationCompleted(object arg) {
            if ((this.SendMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMessageCompleted(this, new SendMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class OnlineClient {
        
        private string userIDField;
        
        private string userAddressField;
        
        /// <remarks/>
        public string UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserAddress {
            get {
                return this.userAddressField;
            }
            set {
                this.userAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResponseResult {
        
        private int requestStatusField;
        
        private string msgField;
        
        /// <remarks/>
        public int RequestStatus {
            get {
                return this.requestStatusField;
            }
            set {
                this.requestStatusField = value;
            }
        }
        
        /// <remarks/>
        public string Msg {
            get {
                return this.msgField;
            }
            set {
                this.msgField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetServiceRunStatusCompletedEventHandler(object sender, GetServiceRunStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceRunStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServiceRunStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetOnlineClientsInfoCompletedEventHandler(object sender, GetOnlineClientsInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOnlineClientsInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOnlineClientsInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OnlineClient[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OnlineClient[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetOnlineClientsTotalCountCompletedEventHandler(object sender, GetOnlineClientsTotalCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOnlineClientsTotalCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOnlineClientsTotalCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void SendMessageCompletedEventHandler(object sender, SendMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591