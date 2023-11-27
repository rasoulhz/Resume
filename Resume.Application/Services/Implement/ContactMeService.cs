using Resume.Application.DTOs;
using Resume.Application.Services.Interface;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
	public class ContactMeService : IContactMeService
	{
		private readonly IContactMeRepository _contactMeRepository;

		public ContactMeService(IContactMeRepository contactMeRepository)
        {
			_contactMeRepository = contactMeRepository;
		}
        public async Task SubmitMessage(ContactMeDTO contactMe)
		{
			await _contactMeRepository.SubmitMessageAsync(DTOMapping.DTOMapping.ToContactMe(contactMe));
		}
	}
}
