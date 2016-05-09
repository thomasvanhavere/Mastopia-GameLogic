﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testservice.ServiceReference1Cal {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/wcfservice")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1Cal.ICalculateService")]
    public interface ICalculateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/GetData", ReplyAction="http://tempuri.org/ICalculateService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/GetData", ReplyAction="http://tempuri.org/ICalculateService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculateService/GetDataUsingDataContractResponse")]
        testservice.ServiceReference1Cal.CompositeType GetDataUsingDataContract(testservice.ServiceReference1Cal.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculateService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<testservice.ServiceReference1Cal.CompositeType> GetDataUsingDataContractAsync(testservice.ServiceReference1Cal.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/Add", ReplyAction="http://tempuri.org/ICalculateService/AddResponse")]
        double Add(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/Add", ReplyAction="http://tempuri.org/ICalculateService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(int Num1, int Num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculateServiceChannel : testservice.ServiceReference1Cal.ICalculateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculateServiceClient : System.ServiceModel.ClientBase<testservice.ServiceReference1Cal.ICalculateService>, testservice.ServiceReference1Cal.ICalculateService {
        
        public CalculateServiceClient() {
        }
        
        public CalculateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public testservice.ServiceReference1Cal.CompositeType GetDataUsingDataContract(testservice.ServiceReference1Cal.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<testservice.ServiceReference1Cal.CompositeType> GetDataUsingDataContractAsync(testservice.ServiceReference1Cal.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public double Add(int Num1, int Num2) {
            return base.Channel.Add(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(int Num1, int Num2) {
            return base.Channel.AddAsync(Num1, Num2);
        }
    }
}
