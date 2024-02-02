using static GymManagmentAPIS.Helper.Enums.Enums;

namespace GymManagmentAPIS.Models.Entity
{
    public class Coach
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        public bool IsAvailableCoach { get; set; }
        public Gender Gender { get; set; } // Enum for gender (e.g., Male, Female, Other)
        // Navigation Property
        public int DepartmentId { get; set; }
       public Department Departments { get; set; }

        List <Subscription > Subscriptions { get; set; }
        public Admin Admins { get; set; }


    }
}
