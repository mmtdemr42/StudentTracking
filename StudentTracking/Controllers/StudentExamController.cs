using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using StudentTracking.BusinessLayer.Concrete;
using StudentTracking.BusinessLayer.ValidationRules.FluentValidation;
using StudentTracking.DataAccessLayer.EntityFramework;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTracking.PresentationLayer.Controllers
{
    public class StudentExamController : Controller
    {
        ExamTYTManager examManager = new ExamTYTManager(new EfExamTYTDal());
        ExamTYTValidation examTYTValidation = new ExamTYTValidation();
        ValidationResult result;

        public IActionResult Index()
        {
            var exames = examManager.List();
            return View(exames);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(ExamTYT examTYT)
        {
            result = examTYTValidation.Validate(examTYT);
            if (result.IsValid)
            {

                examManager.Add(examTYT);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View(examTYT);
        }

        public IActionResult Edit(int id)
        {
            var exam = examManager.GetById(id);
            return View(exam);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(ExamTYT examTYT)
        {
            result = examTYTValidation.Validate(examTYT);
            if (result.IsValid)
            {

                examManager.Update(examTYT);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }

            return View(examTYT);
        }

        public IActionResult Delete(int id)
        {
            var exam = examManager.GetById(id);
            if (exam != null)
            {
                examManager.Delete(exam);
            }
            else
            {
                ViewBag.alerttt = "Böyle bir sınav bulunamadı";
            }
            return RedirectToAction("Index");
        }
    }
}
