namespace GymManagmentAPIS.DTOs.Employee
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public string Password { get; set; }
        public int DepartmentId { get; set; }


    }
}
