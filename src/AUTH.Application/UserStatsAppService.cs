using Abp.Application.Services;
using AUTH.UserStats.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTH.UserStats
{
    public class UserStatsAppService : ApplicationService 
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserStatsAppService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserStatsDto> GetUserStats()
        {
            var onlineUsers = await _userManager.Users.Where(u => u.LastLoginTime.HasValue && u.LastLoginTime.Value >= DateTime.UtcNow.AddMinutes(-10)).ToListAsync();
            var offlineUsers = await _userManager.Users.Where(u => u.LastLoginTime.HasValue && u.LastLoginTime.Value < DateTime.UtcNow.AddMinutes(-10)).ToListAsync();

            var totalUsers = onlineUsers.Count + offlineUsers.Count;
            var onlinePercent = (double)onlineUsers.Count / totalUsers * 100;
            var offlinePercent = (double)offlineUsers.Count / totalUsers * 100;

            return new UserStatsDto
            {
                OnlinePercent = onlinePercent,
                OfflinePercent = offlinePercent
            };
        }
    }
}
