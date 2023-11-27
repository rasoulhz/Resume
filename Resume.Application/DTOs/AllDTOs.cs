using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs
{
    public class AllDTOs
    {
        public PersonalInformationDTO PersonalInformationDTO { get; set; }
        public List<AboutMeDTO> aboutMeDTO { get; set; }
        public List<ExperienceDTO> experiencesDTO { get; set; }
        public List<EducationDTO> educationDTO { get; set; }
        public List<ProjectDTO> projectDTO { get; set; }
        public List<SkillDTO> skillDTO { get; set; }
        public List<ContactMeDTO> contactMeDTO { get; set; }
    }
}
