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
	public class EducationRepository : IEducationRepository
	{
		private readonly AppDbContext _dbContext;

		public EducationRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<List<Education>> GetAllEducationsAsync()
		{
			return await _dbContext.educations.ToListAsync();
		}
	}
}
