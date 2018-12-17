using ASP.NET_MVC.Models;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(Data));
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowXml(HttpPostedFileBase file)
        {
            var data = (Data)formatter.Deserialize(file.InputStream);
            return View(data);
        }
    }
}