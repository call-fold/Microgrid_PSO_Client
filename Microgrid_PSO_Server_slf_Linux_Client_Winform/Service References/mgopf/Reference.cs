﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://210.34.23.37:9983/mgopfserver.wsdl", ConfigurationName="mgopf.mgopfserverPortType")]
    public interface mgopfserverPortType {
        
        // CODEGEN: 消息 mgopfserverRequest 的包装命名空间(urn:mgopfserver)以后生成的消息协定与默认值(http://210.34.23.37:9983/mgopfserver.wsdl)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse mgopfserver(Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse> mgopfserverAsync(Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mgopfserver", WrapperNamespace="urn:mgopfserver", IsWrapped=true)]
    public partial class mgopfserverRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string processNum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string host;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public string dbName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public string port;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
        public string algorithmID;
        
        public mgopfserverRequest() {
        }
        
        public mgopfserverRequest(string processNum, string host, string user, string password, string dbName, string port, string algorithmID) {
            this.processNum = processNum;
            this.host = host;
            this.user = user;
            this.password = password;
            this.dbName = dbName;
            this.port = port;
            this.algorithmID = algorithmID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mgopfserverResponse", WrapperNamespace="urn:mgopfserver", IsWrapped=true)]
    public partial class mgopfserverResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int status;
        
        public mgopfserverResponse() {
        }
        
        public mgopfserverResponse(int status) {
            this.status = status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface mgopfserverPortTypeChannel : Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class mgopfserverPortTypeClient : System.ServiceModel.ClientBase<Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType>, Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType {
        
        public mgopfserverPortTypeClient() {
        }
        
        public mgopfserverPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public mgopfserverPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mgopfserverPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mgopfserverPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType.mgopfserver(Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest request) {
            return base.Channel.mgopfserver(request);
        }
        
        public int mgopfserver(string processNum, string host, string user, string password, string dbName, string port, string algorithmID) {
            Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest inValue = new Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest();
            inValue.processNum = processNum;
            inValue.host = host;
            inValue.user = user;
            inValue.password = password;
            inValue.dbName = dbName;
            inValue.port = port;
            inValue.algorithmID = algorithmID;
            Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse retVal = ((Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType)(this)).mgopfserver(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse> Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType.mgopfserverAsync(Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest request) {
            return base.Channel.mgopfserverAsync(request);
        }
        
        public System.Threading.Tasks.Task<Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverResponse> mgopfserverAsync(string processNum, string host, string user, string password, string dbName, string port, string algorithmID) {
            Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest inValue = new Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverRequest();
            inValue.processNum = processNum;
            inValue.host = host;
            inValue.user = user;
            inValue.password = password;
            inValue.dbName = dbName;
            inValue.port = port;
            inValue.algorithmID = algorithmID;
            return ((Microgrid_PSO_Server_slf_Linux_Client_Winform.mgopf.mgopfserverPortType)(this)).mgopfserverAsync(inValue);
        }
    }
}
