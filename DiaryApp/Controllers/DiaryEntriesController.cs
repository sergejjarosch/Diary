using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();

            return View(objDiaryEntryList);
        }

        public IActionResult Create() 
        {
            var model = new DiaryEntry //neur Eintrag wird mit jetzigem Datum gesetzt
            {
                CreatedDate = DateTime.Now //Datum aus Model auf Jetzt
            };
            return View(model); // Der Vorausgefuellte Eintrag wird in das View uebergeben
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }


    }
}
