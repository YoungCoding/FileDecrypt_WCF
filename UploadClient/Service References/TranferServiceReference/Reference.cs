﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UploadClient.TranferServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TranferServiceReference.ITransferService")]
    public interface ITransferService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransferService/TransferMessage", ReplyAction="http://tempuri.org/ITransferService/TransferMessageResponse")]
        string TransferMessage(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransferService/UploadFile", ReplyAction="http://tempuri.org/ITransferService/UploadFileResponse")]
        System.IO.Stream UploadFile(System.IO.Stream stream);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransferServiceChannel : UploadClient.TranferServiceReference.ITransferService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransferServiceClient : System.ServiceModel.ClientBase<UploadClient.TranferServiceReference.ITransferService>, UploadClient.TranferServiceReference.ITransferService {
        
        public TransferServiceClient() {
        }
        
        public TransferServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransferServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TransferMessage(string msg) {
            return base.Channel.TransferMessage(msg);
        }
        
        public System.IO.Stream UploadFile(System.IO.Stream stream) {
            return base.Channel.UploadFile(stream);
        }
    }
}
