namespace GymSystem.Entities
{
    public class Member:GymUser
    {
        public string? PhotoUrl { get; set; }
        public ICollection<Membership> PlanSubscribtion { get; set; } = new List<Membership>();
    }
}
