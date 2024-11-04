﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ODPC.Authentication;
using ODPC.Data;
using ODPC.Features.Gebruikersgroepen;

namespace ODPC.Features.GebruikersgroepenOverzicht
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize(AdminPolicy.Name)]
    public class GebruikersGroepenController(OdpcDbContext context) : ControllerBase
    {

        private readonly OdpcDbContext _context = context;

        [HttpGet]
        public IAsyncEnumerable<GebruikersgroepModel> Get()
        {
            return _context
              .Gebruikersgroepen
              .OrderBy(x => x.Naam)
              .Select(x => new GebruikersgroepModel { Naam = x.Naam, Uuid = x.Uuid })
              .AsAsyncEnumerable();
        }
    }
}
