﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FilesService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IFileService
    {

        [OperationContract]
        string InsertFile(DocumentDTO document);
        [OperationContract]
        DocumentDTO GetFile(Guid Id);
        [OperationContract]
        List<DocumentDTO> GetFileList(Guid UserId);
        [OperationContract]
        DocumentDTO GetFileParams(Guid? UserId, string fileName, string mimeType);
        [OperationContract]
        string DeleteFile(Guid Id);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
