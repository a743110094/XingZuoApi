using DAL.DAO;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace XingZuoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccountDAO _accountDAO;

        public AccountController(IAccountDAO accountDAO)
        {
            this._accountDAO = accountDAO;
        }

        private readonly ILogger<AccountController> _logger;

     /*   public AccountController(ILogger<AccountController> logger)
        {
            this._logger = logger;
        }*/

        [HttpGet(Name = "GetAllAccount")]
        public IEnumerable<Account> Get()
        {
            /*return Enumerable.Range(1, 5).Select(index => new Entity.Account
            {
                id = 1,
                account="admin",
                password = "123456"
            })
            .ToArray();*/

            return _accountDAO.GetAccounts();
        }
    }
}