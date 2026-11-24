using GymSystem.Enums;

namespace GymSystem.Entities
{
    public class Trainer:GymUser
    {
        public Specialities Speciality { get; set; }
        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
