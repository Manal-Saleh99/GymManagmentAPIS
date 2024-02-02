using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.Subscriptions;

namespace GymManagmentAPIS.Interface
{
    public interface ISharedInterface
    {
        //  searching subscribtions 
        Task<List<SubscriptionInfoDTO>> GetSubscription(string? SubscriptionName , int? DurationInDays, float? Price);

        // regiestration
        Task CreateNewAccount(RegestraitonDTO dto);

        // login 
        Task Login(LoginDTO dto);


        // Reset password

       Task ResetPassword(ResetPasswordDTO dto);



    }
}
