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
	public class ProjectRepository : IProjectRepository
	{
		private readonly AppDbContext _appDbContext;

		public ProjectRepository(AppDbContext appDbContext)
        {
			_appDbContext = appDbContext;
		}
        public async Task<List<Project>> GetAllProjects()
		{
			return await _appDbContext.projects.ToListAsync();
		}
	}
}
