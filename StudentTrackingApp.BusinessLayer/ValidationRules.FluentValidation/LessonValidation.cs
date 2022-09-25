using FluentValidation;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.BusinessLayer.ValidationRules.FluentValidation
{
    public class LessonValidation:AbstractValidator<Lesson>
    {
    }
}
