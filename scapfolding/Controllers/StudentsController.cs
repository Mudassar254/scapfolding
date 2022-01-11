


using scapfolding.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace scapfolding.Controllers
{
    public class StudentsController : Controller
    {
        private StudentDBContext db = new StudentDBContext();
        public async Task<ActionResult> Index()
        {
            return View(await db.Students.ToListAsync());
        }
        public async Task<ActionResult> Details(int? id)
        {
            if(id== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Student student =await db.Students.FindAsync(id);
            if(student== null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind(Include ="ID,Name,Roll")]Student student)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(student);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        //edit
        public async Task<ActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = await db.Students.FindAsync(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Roll")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        //del
        public async Task<ActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = await db.Students.FindAsync(id);
            if(student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
             Student student = await db.Students.FindAsync(id);
            db.Students.Remove(student);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");

        }



    }
}
