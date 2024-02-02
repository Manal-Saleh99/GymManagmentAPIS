using static GymManagmentAPIS.Helper.Enums.Enums;

namespace GymManagmentAPIS.DTOs.coaches
{
    public class CoachCreateDTO
    {     public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }

        public bool IsAvailableCoach { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }



    }
}
