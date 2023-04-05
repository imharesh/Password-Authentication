using Volo.Abp.Application.Services;
using AUTH.UserStats.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AUTH.UserStats
{

    public interface IUserStatsAppService : IApplicationService
    {
        Task<UserStatsDto> GetUserStats();
    }

}
