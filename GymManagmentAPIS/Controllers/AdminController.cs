using GymManagmentAPIS.Context;
using GymManagmentAPIS.DTOs.Admin;
using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.coaches;
using GymManagmentAPIS.DTOs.Departments;
using GymManagmentAPIS.DTOs.Employee;
using GymManagmentAPIS.DTOs.Subscriptions;
using GymManagmentAPIS.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase,IAdminInterface 
    {
        
         public readonly  GymManagmentAPISDbContext _GymManagmentAPISDbContext;
        public AdminController(GymManagmentAPISDbContext context)
        {
            _GymManagmentAPISDbContext = context;
        }

        #region IAction Result
        /// <summary>
        /// an action to add another admin
        /// </summary>

        /// <response code = "200"> scuessful</response>
        ///<response code= "400">something wrong </response>
        ///<response code ="503" > server is not available </response>

        [HttpPost]
        [Route("[action]")]

        public Task<IActionResult> AddAnoutherAdminAction(AdminDTO dto)
        {
            throw new NotImplementedException();
        }



        ///<summary>
        ///an action to create new coaches 
        ///</summary>


        [HttpPost]
        [Route("[action]")]

        public Task<IActionResult> CreateNewCoachesAction(CoachCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to create new departments
        /// </summary>




        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> CreateNewDepartmentAction(DepartmentDTO dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to create new employee  
        /// </summary>




        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> CreateNewEmployeeAction(EmployeeDTO dto)
        {
            throw new NotImplementedException();
        }

        #region Authantication 
        /// <summary>
        /// an action to login 
        /// </summary>



        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> LoginAction(LoginDTO dto)
        {

            throw new NotImplementedException();
        }
        #endregion
        /// <summary>
        /// an action to ReactivateSubscribtion
        /// </summary>




        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> ReactivateSubscribtionAction(bool IsActive)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to update admin
        /// </summary>



        [HttpPut]
        [Route("[action]")]
        public Task<IActionResult> UpdateAdminAction(int AdminId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// an action to update coaches
        /// </summary>




        [HttpPut]
        [Route("[action]")]

        public Task<IActionResult> UpDateCoachesAction(int CoachId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to update departments
        /// </summary>


        [HttpPut]
        [Route("[action]")]
        public Task<IActionResult> UpdateDepartmentAction(int DepartmentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to update employee 
        /// </summary>


        [HttpPut]
        [Route("[action]")]
        public Task<IActionResult> UpdateEmployeeAction(int EmployeeId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// an action to update subscriptions 
        /// </summary>



        [HttpPut]
        [Route("[action]")]
        public Task<IActionResult> UpDateSubscribtionsAction(SubscriptionDetailsDTO dto)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// an action to delete coaches
        /// </summary>




        [HttpDelete]
        [Route("[action]")]
        public Task<IActionResult> DeleteCoachesAction(int CoachId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to delete deparments
        /// </summary>





        [HttpDelete]
        [Route("[action]")]
        public Task<IActionResult> DeleteDepartmentAction(int DepartmentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to delete employee 
        /// </summary>



        [HttpDelete]
        [Route("[action]")]
        public Task<IActionResult> DeleteEmployeeAction(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to DisactivateSubscribtion
        /// </summary>

        [HttpDelete]
        [Route("[action]")]


        public Task<IActionResult> DisactivateSubscribtionAction(bool IsActive)
        {
            throw new NotImplementedException();
        }


        #endregion 



        #region Non Action

        [NonAction ]
        public Task AddAnoutherAdmin(AdminDTO dto)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task CreateNewCoaches(CoachCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task CreateNewDepartment(DepartmentDTO dto)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task CreateNewEmployee(EmployeeDTO dto)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task DeleteCoaches(int CoachId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task DeleteDepartment(int DepartmentId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task DeleteEmployee(int EmployeeId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task DisactivateSubscribtion(bool IsActive)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public async  Task Login(LoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                throw new Exception("Email and Password are required");
            var login = await _GymManagmentAPISDbContext.Clients
                 .Where(x => x.Email.Equals(dto.Email) && x.Password.Equals(dto.Password))
                 .SingleOrDefaultAsync();
            if (login == null)
            {
                throw new Exception("Email Or Password Is Not Correct");
            }
        }
        [NonAction]
        public Task ReactivateSubscribtion(bool IsActive)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task UpdateAdmin(int AdminId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task UpDateCoaches(int CoachId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task UpdateDepartment(int DepartmentId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task UpdateEmployee(int EmployeeId)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task UpDateSubscribtions(SubscriptionDetailsDTO dto)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
