namespace GymSystem.Entities
{
    public class Plan: BaseEntity
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int DurationInMonths { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Membership> PlanSubscribtion { get; set; } = new List<Membership>();
    }
}
