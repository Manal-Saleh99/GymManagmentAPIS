namespace GymManagmentAPIS.DTOs.Subscriptions
{
    public class SubscriptionDetailsDTO
    {
        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float  Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursPerDay { get; set; }
        public bool IsActive { get; set; }
        
        public string SubscriptionType { get; set; }

       




    }
}
