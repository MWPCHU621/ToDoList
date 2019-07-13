using Microsoft.AspNetCore.Antiforgery;
using ToDoList.Controllers;

namespace ToDoList.Web.Host.Controllers
{
    public class AntiForgeryController : ToDoListControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
