using Internship.Core.DomainModels.Entity.Identity;

namespace Internship.Core.DomainModels.ViewModel.Identity.Emails
{
    public class RegisterEmailConfirmationViewModel : EmailsBase
    {
        public User User { set; get; }
        public string EmailConfirmationToken { set; get; }
    }
}
