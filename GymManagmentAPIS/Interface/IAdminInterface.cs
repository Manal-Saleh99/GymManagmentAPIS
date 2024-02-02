using GymManagmentAPIS.DTOs.Admin;
using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.coaches;
using GymManagmentAPIS.DTOs.Departments;
using GymManagmentAPIS.DTOs.Employee;
using GymManagmentAPIS.DTOs.Subscriptions;
using GymManagmentAPIS.Models.Entity;

namespace GymManagmentAPIS.Interface
{
    public interface IAdminInterface

    { // login 

        Task Login(LoginDTO dto);

        
        
        // Create + delete + update coaches
        Task CreateNewCoaches(CoachCreateDTO dto);

        Task DeleteCoaches(int CoachId); 

        Task UpDateCoaches(int CoachId);
        // Create + delete + update Deparment 
        Task CreateNewDepartment(DepartmentDTO dto);
        Task DeleteDepartment(int DepartmentId);
        Task UpdateDepartment(int DepartmentId);

        //   Create + delete + update Employee 

        Task CreateNewEmployee(EmployeeDTO dto);


        Task DeleteEmployee(int EmployeeId);
        Task UpdateEmployee(int EmployeeId);

        // update subscriptions 


        Task UpDateSubscribtions(SubscriptionDetailsDTO dto);

        //  ReactivateSubscribtion
        Task ReactivateSubscribtion(bool IsActive);

        //DisactivateSubscribtion
        Task DisactivateSubscribtion (bool IsActive);

        // add anouther admin 

        Task AddAnoutherAdmin(AdminDTO dto);

        Task UpdateAdmin(int AdminId);


    }
}
