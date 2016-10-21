﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BacLabClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITest", CallbackContract=typeof(BacLabClient.ServiceReference1.ITestCallback))]
    public interface ITest {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITest/testMetod")]
        void testMetod(string str);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITest/testMetod")]
        System.IAsyncResult BegintestMetod(string str, System.AsyncCallback callback, object asyncState);
        
        void EndtestMetod(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITest/ShowMessage")]
        void ShowMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITest/ShowMessage")]
        System.IAsyncResult BeginShowMessage(string message, System.AsyncCallback callback, object asyncState);
        
        void EndShowMessage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestChannel : BacLabClient.ServiceReference1.ITest, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestClient : System.ServiceModel.DuplexClientBase<BacLabClient.ServiceReference1.ITest>, BacLabClient.ServiceReference1.ITest {
        
        private BeginOperationDelegate onBegintestMetodDelegate;
        
        private EndOperationDelegate onEndtestMetodDelegate;
        
        private System.Threading.SendOrPostCallback ontestMetodCompletedDelegate;
        
        public TestClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public TestClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public TestClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TestClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TestClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> testMetodCompleted;
        
        public void testMetod(string str) {
            base.Channel.testMetod(str);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegintestMetod(string str, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegintestMetod(str, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndtestMetod(System.IAsyncResult result) {
            base.Channel.EndtestMetod(result);
        }
        
        private System.IAsyncResult OnBegintestMetod(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string str = ((string)(inValues[0]));
            return this.BegintestMetod(str, callback, asyncState);
        }
        
        private object[] OnEndtestMetod(System.IAsyncResult result) {
            this.EndtestMetod(result);
            return null;
        }
        
        private void OntestMetodCompleted(object state) {
            if ((this.testMetodCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.testMetodCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void testMetodAsync(string str) {
            this.testMetodAsync(str, null);
        }
        
        public void testMetodAsync(string str, object userState) {
            if ((this.onBegintestMetodDelegate == null)) {
                this.onBegintestMetodDelegate = new BeginOperationDelegate(this.OnBegintestMetod);
            }
            if ((this.onEndtestMetodDelegate == null)) {
                this.onEndtestMetodDelegate = new EndOperationDelegate(this.OnEndtestMetod);
            }
            if ((this.ontestMetodCompletedDelegate == null)) {
                this.ontestMetodCompletedDelegate = new System.Threading.SendOrPostCallback(this.OntestMetodCompleted);
            }
            base.InvokeAsync(this.onBegintestMetodDelegate, new object[] {
                        str}, this.onEndtestMetodDelegate, this.ontestMetodCompletedDelegate, userState);
        }
    }
}