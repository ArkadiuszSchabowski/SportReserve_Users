﻿namespace SportReserve_Users
{
    public class AuthenticationSettings
    {
        public string JwtKey { get; set; } = string.Empty;
        public int ExpireDays { get; set; }
        public string JwtIssuer { get; set; } = string.Empty;
    }
}
