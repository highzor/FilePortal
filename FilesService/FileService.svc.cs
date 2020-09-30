using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace FilesService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class FileService : IFileService
    {
        public string InsertFile(DocumentDTO document)
        {
            Decimal FileSize = Decimal.Divide(document.Content.Length, 1048576);
            string fullNamePath = "";
           
            int size = 1000000;
            if (ConfigurationManager.AppSettings["fileSize"] != null)
            {
                size = Int32.Parse(ConfigurationManager.AppSettings["fileSize"]);
            }
            if (document.Content.Length > size)
            {
                fullNamePath = $"{ConfigurationManager.AppSettings["path"]}{document.FileNameInFileStorage}";
                using (FileStream fstream = new FileStream(fullNamePath, FileMode.OpenOrCreate))
                {
                    fstream.Write(document.Content, 0, document.Content.Length);
                }
                string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO FileTable VALUES (@FileId, @UserId, @UserName, @FileName, @FileNameInFileStorage, @MimeType, @Description, @Content, @FileSize, @CreateDate)";
                    command.Parameters.AddWithValue("@FileId", document.FileId);
                    command.Parameters.AddWithValue("@UserId", document.UserId);
                    command.Parameters.AddWithValue("@UserName", document.UserName);
                    command.Parameters.AddWithValue("@FileName", document.FileName);
                    command.Parameters.AddWithValue("@FileNameInFileStorage", document.FileNameInFileStorage);
                    command.Parameters.AddWithValue("@MimeType", document.MimeType);
                    command.Parameters.AddWithValue("@Description", document.Description);
                    command.Parameters.Add("@Content", SqlDbType.VarBinary, -1);
                    command.Parameters["@Content"].Value = DBNull.Value;
                    command.Parameters.AddWithValue("@FileSize", document.FileSize = FileSize);
                    command.Parameters.AddWithValue("@CreateDate", document.CreateDate);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO FileTable VALUES (@FileId, @UserId, @UserName, @FileName, @FileNameInFileStorage, @MimeType, @Description, @Content, @FileSize, @CreateDate)";
                    command.Parameters.AddWithValue("@FileId", document.FileId);
                    command.Parameters.AddWithValue("@UserId", document.UserId);
                    command.Parameters.AddWithValue("@UserName", document.UserName);
                    command.Parameters.AddWithValue("@FileName", document.FileName);
                    command.Parameters.AddWithValue("@FileNameInFileStorage", document.FileNameInFileStorage).Value = DBNull.Value;
                    command.Parameters.AddWithValue("@MimeType", document.MimeType);
                    command.Parameters.AddWithValue("@Description", document.Description);
                    command.Parameters.AddWithValue("@Content", document.Content);
                    command.Parameters.AddWithValue("@FileSize", document.FileSize = FileSize);
                    command.Parameters.AddWithValue("@CreateDate", document.CreateDate);
                    command.ExecuteNonQuery();
                }
            }
            return "ok";
        }
        public List<DocumentDTO> GetFileList(Guid UserId)
        {
            List<DocumentDTO> list = new List<DocumentDTO>();
            string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT FileName, Description, FileSize, CreateDate, FileId FROM FileTable WHERE UserId=@UserId";
                SqlParameter guiParam = new SqlParameter("@UserId", UserId);
                command.Parameters.Add(guiParam);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DocumentDTO document = new DocumentDTO();
                        document.FileName = reader.GetValue(0).ToString();
                        document.Description = reader.GetValue(1).ToString();
                        document.FileSize = (Decimal)reader.GetValue(2);
                        document.CreateDate = (DateTime)reader.GetValue(3);
                        document.FileId = (Guid)reader.GetValue(4);
                        list.Add(document);
                    }
                }
                reader.Close();
            }
            return list;
        }
        public DocumentDTO GetFile(Guid Id)
        {
            DocumentDTO document = new DocumentDTO();
            document.FileId = Id;
            string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT FileNameInFileStorage, FileName, MimeType, Content FROM FileTable WHERE FileId=@Id";
                SqlParameter guiParam = new SqlParameter("@Id", document.FileId);
                command.Parameters.Add(guiParam);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        document.FileNameInFileStorage = reader.GetValue(0).ToString();
                        document.FileName = reader.GetValue(1).ToString();
                        document.MimeType = reader.GetValue(2).ToString();
                        try
                        {
                            document.Content = (byte[])reader.GetValue(3);
                        } catch { }
                    }
                }
                reader.Close();
            }
            if (!document.FileNameInFileStorage.Equals(""))
            {
               string fullNamePath = $"{ConfigurationManager.AppSettings["path"]}{document.FileNameInFileStorage}";
                using (FileStream fstream = File.OpenRead(fullNamePath))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    document.Content = array;
                }
            }
            return document;
        }

        public DocumentDTO GetFileParams(Guid? UserId, string fileName, string mimeType)
        {
            DocumentDTO document = new DocumentDTO();
            string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = @"SELECT UserId, FileName, MimeType, CreateDate FROM FileTable WHERE ";
                if (!String.IsNullOrEmpty(fileName))
                {

                    command.Parameters.AddWithValue("@FileName", fileName + "%");

                }
                command.Connection = connection;
                command.CommandText = @"SELECT UserId, FileName, MimeType, CreateDate FROM FileTable WHERE UserId=@UserId AND FileName LIKE @FileName AND MimeType=@MimeType";
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@FileName", fileName + "%");
                command.Parameters.AddWithValue("@MimeType", mimeType);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                document.UserId = (Guid)reader.GetValue(0);
                document.FileName = reader.GetValue(1).ToString();
                document.MimeType = reader.GetValue(2).ToString();
                document.CreateDate = (DateTime)reader.GetValue(3);
                reader.Close();
            }
            return document;
        }

        public string DeleteFile(Guid Id)
        {
            DocumentDTO document = new DocumentDTO();
            string connectionString = ConfigurationManager.ConnectionStrings["FileService"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"SELECT FileNameInFileStorage FROM FileTable WHERE FileId=@Id";
                SqlParameter guiParam = new SqlParameter("@Id", Id);
                command.Parameters.Add(guiParam);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                document.FileNameInFileStorage = reader.GetValue(0).ToString();
            }

            if (document.FileNameInFileStorage.Equals(""))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM FileTable WHERE FileId=@Id";
                    SqlParameter guiParam = new SqlParameter("@Id", Id);
                    command.Parameters.Add(guiParam);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                string fullNamePath = $"{ConfigurationManager.AppSettings["path"]}{document.FileNameInFileStorage}";
                FileInfo myFile = new FileInfo(fullNamePath);
                if (myFile.Exists)
                {
                    myFile.Delete();
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM FileTable WHERE FileId=@Id";
                    SqlParameter guiParam = new SqlParameter("@Id", Id);
                    command.Parameters.Add(guiParam);
                    command.ExecuteNonQuery();
                }
            }
            return "file not found";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
