using System;

namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestUniversityVoteEditViewModel
    {
        public int Id { get; set; }

        public DateTime? VoteDate { get; set; } = DateTime.Now;

        public string Comment { get; set; }

        public bool IsVoted { get; set; }

        public int UserId { get; set; }
    }
}