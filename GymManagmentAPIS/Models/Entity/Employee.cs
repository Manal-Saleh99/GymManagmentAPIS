using System.Reflection;
using static GymManagmentAPIS.Helper.Enums.Enums;

namespace GymManagmentAPIS.Models.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
       
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }

        List  <Subscription> Subscriptions { get; set; }

        public Admin Admins { get; set; }
        // Other properties as needed



    }
}
