using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class CampusController : Controller
    {
        public string Overview()
        {
            return "KOI provides higher education courses in business, accounting, information technology and management.";
        }

        public string Locations()
        {
            return "KOI campuses are located in Sydney, Australia, providing convenient access for students.";
        }
    }
}