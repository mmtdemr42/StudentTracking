using FluentValidation;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.BusinessLayer.ValidationRules.FluentValidation
{
    public class BookValidation:AbstractValidator<Book>
    {
        public BookValidation()
        {
            RuleFor(b => b.BookName).NotEmpty().WithMessage("Kitap adı boş geçilemez.");
            RuleFor(b => b.BookName).MaximumLength(30).WithMessage("Kitap adının uzunluğu en fazla 30 karakter olabilir.");
            RuleFor(b => b.BookName).MinimumLength(3).WithMessage("Kitap adının uzunluğu en az 3 karakter olabilir.");
            RuleFor(b => b.BookPageCount).NotEmpty().WithMessage("Kitap sayfa sayısı boş geçilemez.");
            RuleFor(b => b.LessonId).NotEmpty().WithMessage("Ders seçiniz.");
        }
    }
}
