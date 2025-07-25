﻿namespace SportReserve_Shared.Models.Race
{
    public class GetRaceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly DateOfStart { get; set; }
        public string City { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public double Distance { get; set; }
        public int Slots { get; set; }
        public bool IsRegistrationOpen { get; set; }
    }
}
