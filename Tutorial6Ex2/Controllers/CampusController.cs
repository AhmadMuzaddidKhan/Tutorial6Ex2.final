using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class CampusController : Controller
    {
        public string Overview()
        {
            return "KOI provides higher education courses in business, accounting and information technology.";
        }

        public string Locations()
        {
            return "KOI campuses are located in Sydney, Australia.";
        }
    }
}