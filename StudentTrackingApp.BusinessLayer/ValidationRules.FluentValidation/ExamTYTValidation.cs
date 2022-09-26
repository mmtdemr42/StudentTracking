using FluentValidation;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.BusinessLayer.ValidationRules.FluentValidation
{
    public class ExamTYTValidation : AbstractValidator<ExamTYT>
    {
        public ExamTYTValidation()
        {
            RuleFor(e => e.ExamTYTName).NotEmpty().WithMessage("Sınav adı boş geçilemez.");
            RuleFor(e => e.ExamTYTName).MaximumLength(50).WithMessage("Sınav adı en fazla 50 karakterden oluşabilir.");
            RuleFor(e => e.ExamTYTName).MinimumLength(10).WithMessage("Sınav adı en az 10 karakterden oluşabilir.");
            RuleFor(e => e.ExamTYTDate).NotEmpty().WithMessage("Sınav tarihi boş geçilemez");
            RuleFor(e => (int)e.TurkceDogru).LessThan(41).WithMessage("Doğru soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Doğru soru sayısı en az 0 olabilir."); 
            RuleFor(e => (int)e.TurkceYanlis).LessThan(41).WithMessage("Yanlış soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Yanlış soru sayısı en az 0 olabilir.");

            RuleFor(e => (int)e.SosyalBilimlerDogru).LessThan(41).WithMessage("Doğru soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Doğru soru sayısı en az 0 olabilir.");
            RuleFor(e => (int)e.SosyalBilimlerYanlis).LessThan(41).WithMessage("Yanlış soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Yanlış soru sayısı en az 0 olabilir.");

            RuleFor(e => (int)e.MatematikDogru).LessThan(41).WithMessage("Doğru soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Doğru soru sayısı en az 0 olabilir.");
            RuleFor(e => (int)e.MatematikYanlis).LessThan(41).WithMessage("Yanlış soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Yanlış soru sayısı en az 0 olabilir.");

            RuleFor(e => (int)e.FenBilimleriDogru).LessThan(41).WithMessage("Doğru soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Doğru soru sayısı en az 0 olabilir.");
            RuleFor(e => (int)e.FenBilimleriYanlis).LessThan(41).WithMessage("Yanlış soru sayısı en fazla 40 olabilir.").GreaterThan(-1).WithMessage("Yanlış soru sayısı en az 0 olabilir.");

            //RuleFor(e => e.FenBilimleriDogru).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.FenBilimleriYanlis).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.MatematikDogru).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.MatematikYanlis).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.TurkceDogru).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.TurkceYanlis).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.SosyalBilimlerDogru).NotEmpty().WithMessage("Değer giriniz");
            //RuleFor(e => e.SosyalBilimlerYanlis).NotEmpty().WithMessage("Değer giriniz");

        }
    }
}
