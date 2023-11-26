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
    public class PersonalInformationRepository : IPersonalInformationRepository
    {
        private readonly AppDbContext _appDbContext;
        public PersonalInformationRepository(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
                
        }
        public async Task<PersonalInformation> GetPersonalInformation()
        {
            return await _appDbContext.PersonalInformation.FirstOrDefaultAsync();
        }
    }
}
