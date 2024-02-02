namespace GymManagmentAPIS.DTOs.Subscriptions
{
    public class SubscriptionInfoDTO
    {
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string Description { get; set; }
        public float  Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursPerDay { get; set; }
        
        public bool IsActive { get; set; }
    }
}
