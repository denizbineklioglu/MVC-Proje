using EntityLayerr.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");

            RuleFor(x => x.Subject).NotEmpty()
            .WithMessage("Konu Adını Boş Geçemezsiniz");

            RuleFor(x => x.UserName).NotEmpty()
            .WithMessage("Kullanıcı Adını boş geçemezsiniz");

            RuleFor(x => x.Subject).MaximumLength(50)
            .WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın.");
        }
    }
}
