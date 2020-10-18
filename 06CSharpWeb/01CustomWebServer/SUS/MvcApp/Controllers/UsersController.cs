using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MvcApp.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login(HttpRequest request)
        {
            return this.View();
        }

        public HttpResponse Register(HttpRequest request)
        {
            return this.View();
        }

        internal HttpResponse DoLogin(HttpRequest arg)
        {
            return this.Redirect("/");
        }
    }
}
