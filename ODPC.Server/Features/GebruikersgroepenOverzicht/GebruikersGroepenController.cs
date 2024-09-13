﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODPC.Controllers;
using ODPC.Data;
using ODPC.Features.Gebruikersgroepen;

namespace ODPC.Features.GebruikersgroepenOverzicht
{
    [Route("api/[controller]")]
    [ApiController]
    public class GebruikersGroepenController() : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GebruikersgroepModel> Get()
        {
            return new GebruikersgroepModel[] {
                new() { Id = "fb83651b-72e4-4d7c-a319-9966c3cd4ee5", Name="Groep 1" },
                new() { Id = "5bdabfa6-36c6-49db-b2a2-91395b4fa4a9", Name="Groep 2" },
                new() { Id = "94010ac6-1be3-429b-956f-1f28bd7389b0", Name="Groep 3" },
                new() { Id = "1b3bc012-b288-4f8e-9552-81fdb0f01418", Name="Groep 4" }
            };
        }
    }
}