using SUS.HTTP;
using SUS.MvcFramework;
using System.IO;
using System.Linq;
using System.Text;

namespace MvcApp.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login(HttpRequest request)
        {
            return this.View("Views/Users/Login.html");
        }

        public HttpResponse Register(HttpRequest request)
        {
            return this.View("Views/Users/Register.html");
        }
    }
}
