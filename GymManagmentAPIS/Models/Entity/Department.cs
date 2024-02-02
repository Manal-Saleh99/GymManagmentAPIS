namespace GymManagmentAPIS.Models.Entity
{
    public class Department
    {

        public int DepartmentId { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
      
        public string Description{ get; set;
        }
        
      public Coach Coachs { get; set; }

       List<Subscription > Subscriptions { get; set; }
        public Admin Admins { get; set; }
    }
}
