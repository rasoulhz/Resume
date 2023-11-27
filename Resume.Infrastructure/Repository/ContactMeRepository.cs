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
	public class ContactMeRepository : IContactMeRepository
	{
		private readonly AppDbContext _appDbContext;

		public ContactMeRepository(AppDbContext appDbContext)
        {
			_appDbContext = appDbContext;
		}
        public async Task SubmitMessageAsync(ContactMe contactMe)
		{
			await _appDbContext.contactMes.AddAsync(contactMe);
			await _appDbContext.SaveChangesAsync();
		}
	}
}
