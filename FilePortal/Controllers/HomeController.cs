using FilePortal.FileServiceReference;
using FilePortal.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilePortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserPage()
        {
            FileServiceReference.FileServiceClient client = new FileServiceReference.FileServiceClient();
            Guid userGuid = new Guid(User.Identity.GetUserId());
            ViewBag.Files = client.GetFileList(userGuid).ToList();
            return View();
        }
        public ViewResult UserFilesList()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Upload()
        {
            foreach (string file in Request.Files)
            {
                var upload = Request.Files[file];
                if (upload != null)
                {
                    FileServiceReference.FileServiceClient client = new FileServiceReference.FileServiceClient();
                    DocumentDTO doc = new DocumentDTO();
                    string fileName = System.IO.Path.GetFileName(upload.FileName);
                    // сохраняем файл в папку Files в проекте
                    //upload.SaveAs(Server.MapPath("~/Files/" + fileName));
                    MemoryStream target = new MemoryStream();
                    upload.InputStream.CopyTo(target);
                    byte[] data = target.ToArray();
                    doc.Content = data;
                    doc.CreateDate = DateTime.Now;
                    doc.FileName = fileName;
                    doc.FileId = Guid.NewGuid();
                    doc.MimeType = upload.ContentType;
                    doc.UserName = User.Identity.GetUserName();
                    doc.UserId = new Guid(User.Identity.GetUserId());
                    doc.FileSize = Decimal.Divide(doc.Content.Length, 1048576);
                    //doc.FileSize = doc.Content.Length / 1048576;
                    doc.FileNameInFileStorage = doc.FileId.ToString();
                    doc.Description = "example";
                    client.InsertFile(doc);
                }
            }
            return Json("файл загружен");
        }

        public JsonResult Delete(string[] id)
        {
            if (id.Length > 0)
            {
                foreach (string onesId in id)
                {
                    Guid fileId = new Guid(onesId);
                    FileServiceReference.FileServiceClient client = new FileServiceReference.FileServiceClient();
                    DocumentDTO doc = new DocumentDTO();
                    client.DeleteFile(fileId);
                }
                return Json("файлы удалены");
            }
            return Json("файлы не удалены");
        }
        public ActionResult Download(Guid id)
        {
            FileServiceReference.FileServiceClient client = new FileServiceReference.FileServiceClient();
            DocumentDTO document = client.GetFile(id);

            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + document.FileName);
            Response.AddHeader("Content-Length", document.Content.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.OutputStream.Write(document.Content, 0, document.Content.Length);
            Response.End();
            return RedirectToRoute(new { controller = "Home", action = "UserPage" });
        }
    }
}