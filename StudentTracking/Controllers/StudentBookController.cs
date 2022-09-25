using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentTracking.BusinessLayer.Concrete;
using StudentTracking.BusinessLayer.ValidationRules.FluentValidation;
using StudentTracking.DataAccessLayer.Concrete.Repository;
using StudentTracking.DataAccessLayer.EntityFramework;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTracking.PresentationLayer.Controllers
{
    public class StudentBookController : Controller
    {
        BookManager bookmanager = new BookManager(new EfBookDal());
        LessonManager lessonManager = new LessonManager(new EfLessonDal());

        BookValidation bookValidation = new BookValidation();
        ValidationResult result;
        public IActionResult Index()
        {
            var books = bookmanager.List();
            return View(books);
        }

        public IActionResult Create()
        {
            List<SelectListItem> valueBook = (from lesson in lessonManager.List()
                                                  select new SelectListItem
                                                  {
                                                      Text = lesson.LessonName,
                                                      Value = lesson.LessonId.ToString(),
                                                  }).ToList();
            ViewBag.valueBook = valueBook;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            List<SelectListItem> valueBook = (from lesson in lessonManager.List()
                                              select new SelectListItem
                                              {
                                                  Text = lesson.LessonName,
                                                  Value = lesson.LessonId.ToString(),
                                              }).ToList();
            ViewBag.valueBook = valueBook;

            result = bookValidation.Validate(book);
            if (result.IsValid)
            {
                bookmanager.Add(book);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View(book);
        }
    }
}
