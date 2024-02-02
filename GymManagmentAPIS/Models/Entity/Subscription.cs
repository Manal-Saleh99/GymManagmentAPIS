using static GymManagmentAPIS.Helper.Enums.Enums;

namespace GymManagmentAPIS.Models.Entity
{
    public class Subscription
    {

        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string Description { get; set; }
        public float  Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursPerDay { get; set; }
        public DateTime SubscribtionDate { get; set; }
        public bool IsActive { get; set; }
        // Other properties as needed
        public SubscriptionType SubscriptionType { get; set; }

        public Coach Coachs { get; set; }
        public Employee Employees { get; set; }

        public Client Clients { get; set; }

        public Department Departments { get; set; }

    }
}
