using System.ComponentModel.DataAnnotations.Schema;

namespace GymSystem.Entities
{
    public class Membership:BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string Status => (EndDate >= DateTime.Now) ? "Active" : 
                                (StartDate > DateTime.Now) ? "Upcoming" : "Expired";
    }
}
