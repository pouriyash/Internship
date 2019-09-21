using IInternship.Core.DomainModels.ViewModel.Identity.Settings;

namespace Internship.Core.DomainModels.ViewModel.Identity.Settings
{
    public class Connectionstrings
    {
        public SqlServer SqlServer { get; set; }
        public Localdb LocalDb { get; set; }
    }
}