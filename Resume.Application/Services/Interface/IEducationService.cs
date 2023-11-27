using Resume.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
	public interface IEducationService
	{
		Task<List<EducationDTO>> GetAllEducationDTOAsync();
	}
}
