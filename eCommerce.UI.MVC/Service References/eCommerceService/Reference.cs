﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.UI.MVC.eCommerceService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="eCommerceService.IeCommerceService")]
    public interface IeCommerceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/GetProductos", ReplyAction="http://tempuri.org/IeCommerceService/GetProductosResponse")]
        eCommerce.Service.DataContracts.GetProductosResponse GetProductos(eCommerce.Service.DataContracts.GetProductosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/GetProductos", ReplyAction="http://tempuri.org/IeCommerceService/GetProductosResponse")]
        System.Threading.Tasks.Task<eCommerce.Service.DataContracts.GetProductosResponse> GetProductosAsync(eCommerce.Service.DataContracts.GetProductosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/AddProducto", ReplyAction="http://tempuri.org/IeCommerceService/AddProductoResponse")]
        eCommerce.Service.DataContracts.SaveProductoResponse AddProducto(eCommerce.Service.DataContracts.SaveProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/AddProducto", ReplyAction="http://tempuri.org/IeCommerceService/AddProductoResponse")]
        System.Threading.Tasks.Task<eCommerce.Service.DataContracts.SaveProductoResponse> AddProductoAsync(eCommerce.Service.DataContracts.SaveProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/DeleteProducto", ReplyAction="http://tempuri.org/IeCommerceService/DeleteProductoResponse")]
        eCommerce.Service.DataContracts.DeleteProductoResponse DeleteProducto(eCommerce.Service.DataContracts.DeleteProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/DeleteProducto", ReplyAction="http://tempuri.org/IeCommerceService/DeleteProductoResponse")]
        System.Threading.Tasks.Task<eCommerce.Service.DataContracts.DeleteProductoResponse> DeleteProductoAsync(eCommerce.Service.DataContracts.DeleteProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/EditProducto", ReplyAction="http://tempuri.org/IeCommerceService/EditProductoResponse")]
        eCommerce.Service.DataContracts.EditProductoResponse EditProducto(eCommerce.Service.DataContracts.EditProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/EditProducto", ReplyAction="http://tempuri.org/IeCommerceService/EditProductoResponse")]
        System.Threading.Tasks.Task<eCommerce.Service.DataContracts.EditProductoResponse> EditProductoAsync(eCommerce.Service.DataContracts.EditProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/GetProducto", ReplyAction="http://tempuri.org/IeCommerceService/GetProductoResponse")]
        eCommerce.Service.DataContracts.GetProductoResponse GetProducto(eCommerce.Service.DataContracts.GetProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IeCommerceService/GetProducto", ReplyAction="http://tempuri.org/IeCommerceService/GetProductoResponse")]
        System.Threading.Tasks.Task<eCommerce.Service.DataContracts.GetProductoResponse> GetProductoAsync(eCommerce.Service.DataContracts.GetProductoRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IeCommerceServiceChannel : eCommerce.UI.MVC.eCommerceService.IeCommerceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IeCommerceServiceClient : System.ServiceModel.ClientBase<eCommerce.UI.MVC.eCommerceService.IeCommerceService>, eCommerce.UI.MVC.eCommerceService.IeCommerceService {
        
        public IeCommerceServiceClient() {
        }
        
        public IeCommerceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IeCommerceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IeCommerceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IeCommerceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public eCommerce.Service.DataContracts.GetProductosResponse GetProductos(eCommerce.Service.DataContracts.GetProductosRequest request) {
            return base.Channel.GetProductos(request);
        }
        
        public System.Threading.Tasks.Task<eCommerce.Service.DataContracts.GetProductosResponse> GetProductosAsync(eCommerce.Service.DataContracts.GetProductosRequest request) {
            return base.Channel.GetProductosAsync(request);
        }
        
        public eCommerce.Service.DataContracts.SaveProductoResponse AddProducto(eCommerce.Service.DataContracts.SaveProductoRequest request) {
            return base.Channel.AddProducto(request);
        }
        
        public System.Threading.Tasks.Task<eCommerce.Service.DataContracts.SaveProductoResponse> AddProductoAsync(eCommerce.Service.DataContracts.SaveProductoRequest request) {
            return base.Channel.AddProductoAsync(request);
        }
        
        public eCommerce.Service.DataContracts.DeleteProductoResponse DeleteProducto(eCommerce.Service.DataContracts.DeleteProductoRequest request) {
            return base.Channel.DeleteProducto(request);
        }
        
        public System.Threading.Tasks.Task<eCommerce.Service.DataContracts.DeleteProductoResponse> DeleteProductoAsync(eCommerce.Service.DataContracts.DeleteProductoRequest request) {
            return base.Channel.DeleteProductoAsync(request);
        }
        
        public eCommerce.Service.DataContracts.EditProductoResponse EditProducto(eCommerce.Service.DataContracts.EditProductoRequest request) {
            return base.Channel.EditProducto(request);
        }
        
        public System.Threading.Tasks.Task<eCommerce.Service.DataContracts.EditProductoResponse> EditProductoAsync(eCommerce.Service.DataContracts.EditProductoRequest request) {
            return base.Channel.EditProductoAsync(request);
        }
        
        public eCommerce.Service.DataContracts.GetProductoResponse GetProducto(eCommerce.Service.DataContracts.GetProductoRequest request) {
            return base.Channel.GetProducto(request);
        }
        
        public System.Threading.Tasks.Task<eCommerce.Service.DataContracts.GetProductoResponse> GetProductoAsync(eCommerce.Service.DataContracts.GetProductoRequest request) {
            return base.Channel.GetProductoAsync(request);
        }
    }
}