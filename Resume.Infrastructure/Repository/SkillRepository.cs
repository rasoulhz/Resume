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
	public class SkillRepository : ISkillRepository
	{
		private readonly AppDbContext _appDbContext;

		public SkillRepository(AppDbContext appDbContext)
        {
			_appDbContext = appDbContext;
		}
        public async Task<List<Skill>> GetAllSkills()
		{
			return await _appDbContext.skills.ToListAsync();
		}
	}
}
