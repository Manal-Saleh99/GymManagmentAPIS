namespace GymManagmentAPIS.Models.Entity
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }

        List <Employee > Employees { get; set; }


        List<Coach > Coachs { get; set; }

        List<Department> Departments { get; set; }

    }
}
