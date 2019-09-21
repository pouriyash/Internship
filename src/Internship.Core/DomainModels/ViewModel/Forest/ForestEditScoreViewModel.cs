

namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestEditScoreViewModel
    {
        public ForestEditScoreViewModel(int? score)
        {
            this.Score = score;
        }

        public int? Score { get; set; } = 0;
    }
}
