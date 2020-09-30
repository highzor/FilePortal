﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilePortal.FileServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentDTO", Namespace="http://schemas.datacontract.org/2004/07/FilesService")]
    [System.SerializableAttribute()]
    public partial class DocumentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid FileIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameInFileStorageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FileSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MimeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public byte[] Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileId {
            get {
                return this.FileIdField;
            }
            set {
                if ((this.FileIdField.Equals(value) != true)) {
                    this.FileIdField = value;
                    this.RaisePropertyChanged("FileId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileNameInFileStorage {
            get {
                return this.FileNameInFileStorageField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameInFileStorageField, value) != true)) {
                    this.FileNameInFileStorageField = value;
                    this.RaisePropertyChanged("FileNameInFileStorage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal FileSize {
            get {
                return this.FileSizeField;
            }
            set {
                if ((this.FileSizeField.Equals(value) != true)) {
                    this.FileSizeField = value;
                    this.RaisePropertyChanged("FileSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MimeType {
            get {
                return this.MimeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MimeTypeField, value) != true)) {
                    this.MimeTypeField = value;
                    this.RaisePropertyChanged("MimeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/FilesService")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FileServiceReference.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/InsertFile", ReplyAction="http://tempuri.org/IFileService/InsertFileResponse")]
        string InsertFile(FilePortal.FileServiceReference.DocumentDTO document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/InsertFile", ReplyAction="http://tempuri.org/IFileService/InsertFileResponse")]
        System.Threading.Tasks.Task<string> InsertFileAsync(FilePortal.FileServiceReference.DocumentDTO document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFile", ReplyAction="http://tempuri.org/IFileService/GetFileResponse")]
        FilePortal.FileServiceReference.DocumentDTO GetFile(System.Guid Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFile", ReplyAction="http://tempuri.org/IFileService/GetFileResponse")]
        System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO> GetFileAsync(System.Guid Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileList", ReplyAction="http://tempuri.org/IFileService/GetFileListResponse")]
        FilePortal.FileServiceReference.DocumentDTO[] GetFileList(System.Guid UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileList", ReplyAction="http://tempuri.org/IFileService/GetFileListResponse")]
        System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO[]> GetFileListAsync(System.Guid UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileParams", ReplyAction="http://tempuri.org/IFileService/GetFileParamsResponse")]
        FilePortal.FileServiceReference.DocumentDTO GetFileParams(System.Nullable<System.Guid> UserId, string fileName, string mimeType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFileParams", ReplyAction="http://tempuri.org/IFileService/GetFileParamsResponse")]
        System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO> GetFileParamsAsync(System.Nullable<System.Guid> UserId, string fileName, string mimeType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DeleteFile", ReplyAction="http://tempuri.org/IFileService/DeleteFileResponse")]
        string DeleteFile(System.Guid Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DeleteFile", ReplyAction="http://tempuri.org/IFileService/DeleteFileResponse")]
        System.Threading.Tasks.Task<string> DeleteFileAsync(System.Guid Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFileService/GetDataUsingDataContractResponse")]
        FilePortal.FileServiceReference.CompositeType GetDataUsingDataContract(FilePortal.FileServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFileService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<FilePortal.FileServiceReference.CompositeType> GetDataUsingDataContractAsync(FilePortal.FileServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : FilePortal.FileServiceReference.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<FilePortal.FileServiceReference.IFileService>, FilePortal.FileServiceReference.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertFile(FilePortal.FileServiceReference.DocumentDTO document) {
            return base.Channel.InsertFile(document);
        }
        
        public System.Threading.Tasks.Task<string> InsertFileAsync(FilePortal.FileServiceReference.DocumentDTO document) {
            return base.Channel.InsertFileAsync(document);
        }
        
        public FilePortal.FileServiceReference.DocumentDTO GetFile(System.Guid Id) {
            return base.Channel.GetFile(Id);
        }
        
        public System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO> GetFileAsync(System.Guid Id) {
            return base.Channel.GetFileAsync(Id);
        }
        
        public FilePortal.FileServiceReference.DocumentDTO[] GetFileList(System.Guid UserId) {
            return base.Channel.GetFileList(UserId);
        }
        
        public System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO[]> GetFileListAsync(System.Guid UserId) {
            return base.Channel.GetFileListAsync(UserId);
        }
        
        public FilePortal.FileServiceReference.DocumentDTO GetFileParams(System.Nullable<System.Guid> UserId, string fileName, string mimeType) {
            return base.Channel.GetFileParams(UserId, fileName, mimeType);
        }
        
        public System.Threading.Tasks.Task<FilePortal.FileServiceReference.DocumentDTO> GetFileParamsAsync(System.Nullable<System.Guid> UserId, string fileName, string mimeType) {
            return base.Channel.GetFileParamsAsync(UserId, fileName, mimeType);
        }
        
        public string DeleteFile(System.Guid Id) {
            return base.Channel.DeleteFile(Id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteFileAsync(System.Guid Id) {
            return base.Channel.DeleteFileAsync(Id);
        }
        
        public FilePortal.FileServiceReference.CompositeType GetDataUsingDataContract(FilePortal.FileServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<FilePortal.FileServiceReference.CompositeType> GetDataUsingDataContractAsync(FilePortal.FileServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}