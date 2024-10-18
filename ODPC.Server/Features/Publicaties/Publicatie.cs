﻿namespace ODPC.Features.Publicaties
{
    public class Publicatie
    {
        public Guid Uuid { get; set; }
        public string? OfficieleTitel { get; set; }
        public string? VerkorteTitel { get; set; }
        public string? Omschrijving { get; set; }
        public DateTime Registratiedatum { get; set; }
        public string? Status { get; set; }
    }
}
