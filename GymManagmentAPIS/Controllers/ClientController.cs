using GymManagmentAPIS.Context;
using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.Subscriptions;
using GymManagmentAPIS.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase,IClientInterface 
    {
        public  readonly  GymManagmentAPISDbContext _GymManagmentAPISDbContext;

        public ClientController(GymManagmentAPISDbContext context)
        {
            _GymManagmentAPISDbContext = context;
        }

        #region IACTION END POINT 
        /// <summary>
        /// an action return isAvaliable coach or not 
        /// </summary>
        /// <response code = "200"> scuessful</response>
        ///<response code= "400">something wrong </response>
        ///<response code ="503" > server is not available </response>

        [HttpGet]
        [Route("[action]")]

        public Task<IActionResult> AvailableCoachAction(bool IsAvailableCoach)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// an action buy subscriptions 
        /// </summary>


        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> BuySubscriptionAction(BuySubscriptionDTO dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to login 
        /// </summary>


        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> LoginAction(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// an action to regerstation
        /// </summary>





        [HttpPost]
        [Route("[action]")]
        public Task<IActionResult> RegestraitonAction(RegestraitonDTO dto)
        {
            throw new NotImplementedException();
        }

        #endregion 






        #region NON action

        [NonAction ]
        public Task AvailableCoach(bool IsAvailableCoach)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task BuySubscription(BuySubscriptionDTO dto)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public  async Task Login(LoginDTO dto)
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
        public async  Task Regestraiton(RegestraitonDTO dto)
        {
            //validation
            if (string.IsNullOrEmpty(dto.Email))
                throw new Exception("Email Is Required");
            if (string.IsNullOrEmpty(dto.Phone))
                throw new Exception("Phone Is Required");
            if (string.IsNullOrEmpty(dto.Password))
                throw new Exception("Password Is Required");
            if (string.IsNullOrEmpty(dto.FirstName))
                throw new Exception("FirstName Is Required");

            if (string.IsNullOrEmpty(dto.LastName))
                throw new Exception("LastName Is Required");
           
            dto .Email = dto.Email;
            dto .Phone = dto.Phone;
            dto .Password = dto.Password;
           dto.FirstName = dto.FirstName;
            dto .LastName = dto.LastName;

            await _GymManagmentAPISDbContext.AddAsync(dto );
            await _GymManagmentAPISDbContext.SaveChangesAsync();
        }
        #endregion 
    }
}
