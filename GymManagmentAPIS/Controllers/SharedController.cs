using GymManagmentAPIS.Context;
using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.Subscriptions;
using GymManagmentAPIS.Interface;
using GymManagmentAPIS.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase,ISharedInterface 
    {

        public readonly  GymManagmentAPISDbContext _GymManagmentAPISDbContext;

        public SharedController(GymManagmentAPISDbContext context)
        {
            _GymManagmentAPISDbContext = context;
        }

        #region Iaction End Point 

        /// <summary>
        /// an action to get subscriptions
        /// </summary>
        /// <response code = "200"> scuessful</response>
        ///<response code= "400">something wrong </response>
        ///<response code ="503" > server is not available </response>

        [HttpGet]
        [Route("[action]")]
        public async  Task<IActionResult> GetSubscriptionAction(string? SubscriptionName, int? DurationInDays, float? Price)
        {
            try
            {
                return Ok(await GetSubscriptionAction(SubscriptionName , DurationInDays , Price ));
            }
            catch (Exception ex)
            {
                throw new Exception("Test Exception");
            }
        }
        /// <summary>
        /// an action to create new account
        /// </summary>




        [HttpPost]
        [Route("[action]")]
        public  async  Task<IActionResult> CreateNewAccountAction(RegestraitonDTO dto)
        {
            try
            {
                await CreateNewAccount(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "New Account Has Been Activated" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Createing Account  {ex.Message}" };
            }
        }


        /// <summary>
        /// an action to login 
        /// </summary>

        [HttpPost]
        [Route("[action]")]
        public async  Task<IActionResult> LoginAction(LoginDTO dto)
        {
            try
            {
                await Login(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Login Success" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Login Failed {ex.Message}" };
            }
        }



        /// <summary>
        /// an action to reset password 
        /// </summary>

        [HttpPost]
        [Route("[action]")]
        public async  Task<IActionResult> ResetPasswordAction(ResetPasswordDTO dto)
        {
            try
            {
                await ResetPassword(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "ResetPassword Success" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"ResetPassword Failed {ex.Message}" };
            }
        }


        #endregion








        #region Non Acion End Point 

        [NonAction ]
        public async  Task CreateNewAccount(RegestraitonDTO dto)
        {

            //validation
            if (string.IsNullOrEmpty(dto.Email))
                throw new Exception("Email Is Required");
            if (string.IsNullOrEmpty(dto.Phone))
                throw new Exception("Phone Is Required");
            if (string.IsNullOrEmpty(dto.Password))
                throw new Exception("Password Is Required");
            if (string.IsNullOrEmpty(dto.FirstName ))
                throw new Exception("FirstName Is Required");

            if (string.IsNullOrEmpty(dto.LastName ))
                throw new Exception("LastName Is Required");
            Client  user = new Client ();
            user.Email = dto.Email;
            user.Phone = dto.Phone;
            user.Password = dto.Password;
            user.FirstName = dto.FirstName ;
            user.LastName = dto.LastName ;
           
            await _GymManagmentAPISDbContext.AddAsync(user);
            await _GymManagmentAPISDbContext.SaveChangesAsync();
        }
        [NonAction]
        public Task<List<SubscriptionInfoDTO>> GetSubscription(string? SubscriptionName, int? DurationInDays, float? Price)
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
        public async  Task ResetPassword(ResetPasswordDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Phone))
                throw new Exception("Email and Phone are required");
            var user = await _GymManagmentAPISDbContext.Clients .Where(x => x.Email.Equals(dto.Email)
            && x.Phone.Equals(dto.Phone)).SingleOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("User Not Found");
            }
            else
            {
                if (string.IsNullOrEmpty(dto.Password) || string.IsNullOrEmpty(dto.ConfirmPassword))
                    throw new Exception("Password and ConfirmPassword are required");
                else
                {
                    if (dto.Password.Equals(dto.ConfirmPassword))
                    {
                        user.Password = dto.ConfirmPassword;
                        _GymManagmentAPISDbContext.Update(user);
                        await _GymManagmentAPISDbContext.SaveChangesAsync();
                    }
                }

            }
        }

        #endregion 
    }
}
