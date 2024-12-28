using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proekt.Dto;
using Proekt.Data;
using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;

namespace Proekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CarsController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public CarsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
    }
}
