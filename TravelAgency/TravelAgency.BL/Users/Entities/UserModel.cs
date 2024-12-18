﻿namespace TravelAgency.BL.Users.Entity
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string? EmailAddress { get; set; } 
        public string? Position { get; set; } 
    }
}