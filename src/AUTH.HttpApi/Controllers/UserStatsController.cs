using AUTH.UserStats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Volo.Abp.AspNetCore.Mvc;
namespace AUTH.Controllers
{

    [System.Web.Http.Route("api/user-stats")]
    public class UserStatsController : ApiController
    {
        private readonly IUserStatsAppService _userStatsAppService;

        public UserStatsController(IUserStatsAppService userStatsAppService)
        {
            _userStatsAppService = userStatsAppService;
        }

        [System.Web.Http.HttpGet]
        public async Task<UserStatsDto> Get()
        {
            return await _userStatsAppService.GetUserStats();
        }
    }
}
