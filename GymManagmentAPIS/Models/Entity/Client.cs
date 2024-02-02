﻿namespace GymManagmentAPIS.Models.Entity
{
    public class Client
    {

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public string Password { get; set; }

        List <Subscription > Subscriptions { get; set; }

    }
}
