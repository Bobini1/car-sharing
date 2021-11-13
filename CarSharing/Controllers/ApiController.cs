using ASP.NET1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET1
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private readonly DatabaseContext _database;

        public ApiController(ILogger<ApiController> logger, DatabaseContext context)
        {
            _logger = logger;
            _database = context;
        }

        [HttpGet]
        [Route("accounts")]
        public List<Account> GetAllUsers() => _database.getAccounts();

        [HttpPost]
        [Route("account")]
        [AllowAnonymous]
        public IActionResult AddUser([FromBody] Account user)
        {
            _logger.LogInformation("Add User for UserId: {UserId}", user.Account_ID);
            _database.AddUser(user);
            return Ok(user);
        }
    }
}
