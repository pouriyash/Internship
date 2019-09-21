using Internship.Core.DomainModels.Entity.Identity;

namespace Internship.Core.DomainModels.ViewModel.Identity.Emails
{
    public class ChangePasswordNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}