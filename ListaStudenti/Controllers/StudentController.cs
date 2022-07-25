using ListaStudenti.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaStudenti.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext StudentContext { get; set; }

        public StudentController(StudentContext studentContext)
        {
            StudentContext = studentContext;
        }

        [HttpGet]
        public IActionResult Adaugare()
        {
            ViewBag.Actiune = "Adauga";

            return View("Editare", new student());
        }

        [HttpGet]

        public IActionResult Editare(int id)
        {
            ViewBag.Actiune = "Editare";

            var student = StudentContext.Studenti.Find(id);

            return View(student);
        }
        [HttpPost]

        public IActionResult Editare(student Student)
        {
            if (ModelState.IsValid)
            {
                if (Student.StudentID == 0) StudentContext.Studenti.Add(Student);
                else StudentContext.Studenti.Update(Student);

                StudentContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
              ViewBag.Actiune = Student.StudentID == 0 ? "Adaugare" : "Editare ";

                return View(Student);
            }
            
        }
        [HttpGet]

        public IActionResult Stergere(int id)
        {
            var student = StudentContext.Studenti.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Stergere(student Student)
        {
            StudentContext.Studenti.Remove(Student);
            StudentContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
