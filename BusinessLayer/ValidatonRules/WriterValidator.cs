using EntityLayerr.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty()
            .WithMessage("Yazar adını boş geçemezsiniz");

            RuleFor(x => x.WriterSurname).NotEmpty()
            .WithMessage("Yazar soyadını boş Geçemezsiniz");

            RuleFor(x => x.WriterAbout).NotEmpty()
            .WithMessage("Hakkımda kısmını boş geçemezsiniz.");

            // Ödev
            RuleFor(x => x.WriterAbout).Must(x=> x.Contains("a"))
            .WithMessage("Hakkımda kısmında a harfi bulunmak zorunda");

            RuleFor(x => x.WriterName).MinimumLength(2)
            .WithMessage("Lütfen en az 2 karakter girişi yapın.");

            RuleFor(x => x.WriterName).MaximumLength(50)
            .WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın.");
        }
    }
}
