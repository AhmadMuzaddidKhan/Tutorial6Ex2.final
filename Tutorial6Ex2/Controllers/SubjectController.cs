using System.Web;
using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class SubjectController : Controller
    {
        public string Index()
        {
            return "This page is to show the subject homepage";
        }

        public string Subjects()
        {
            return "This page is to show the list of subjects that the student is enrolled in";
        }

        public string Details(string SubjectId)
        {
            return HttpUtility.HtmlEncode("Subject Code: " + SubjectId);
        }

        public ActionResult Edit(int SubjectId)
        {
            // Update subject in the database
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int SubjectId)
        {
            // Delete subject from the database
            return RedirectToAction("Index");
        }
    }
}