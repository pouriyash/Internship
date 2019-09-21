using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using Internship.Core.DomainModels.Entity.Identity;
using Internship.Core.DomainModels.ViewModel.Identity;

namespace Internship.Infrastructure.Services.Contracts.Identity
{
    public interface ISiteStatService
    {
        Task<List<User>> GetOnlineUsersListAsync(int numbersToTake, int minutesToTake);

        Task<List<User>> GetTodayBirthdayListAsync();

        Task UpdateUserLastVisitDateTimeAsync(ClaimsPrincipal claimsPrincipal);

        Task<AgeStatViewModel> GetUsersAverageAge();
    }
}