using GymManagmentAPIS.DTOs.Authantication;
using GymManagmentAPIS.DTOs.Subscriptions;

namespace GymManagmentAPIS.Interface
{
    public interface IClientInterface

    {
        // creat new account 
       Task Regestraiton(RegestraitonDTO dto);

        // login 

        Task Login(LoginDTO dto);



        // buy subscribtion 

        Task BuySubscription(BuySubscriptionDTO dto );

        // Available Coaches 
        Task AvailableCoach(bool IsAvailableCoach);

        




    }
}
