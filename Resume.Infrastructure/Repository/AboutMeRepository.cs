using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.appDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class AboutMeRepository : IAboutMeRepository
    {
        private readonly AppDbContext _dbContext;

        public AboutMeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<AboutMe>> GetAboutMeListAsync()
        {
            return await _dbContext.aboutMes.ToListAsync();
        }
    }
}
