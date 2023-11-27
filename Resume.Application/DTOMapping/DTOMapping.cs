using Resume.Application.DTOs;
using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOMapping
{
    public static class DTOMapping
    {
        public static PersonalInformationDTO ToPersonalInformationDTO(PersonalInformation personalInformation)
        {
            PersonalInformationDTO personalInformationDTO = new()
            {
                Name = personalInformation.Name,
                Address = personalInformation.Address,
                JobTitle = personalInformation.JobTitle,
                Description = personalInformation.Description,
                DescriptionTitle = personalInformation.DescriptionTitle,
                PhoneNumber = personalInformation.PhoneNumber,
                BirthDate = personalInformation.BirthDate,
                WebSite = personalInformation.WebSite,
                Email = personalInformation.Email,
            };
            return personalInformationDTO;
        }
        public static AboutMeDTO ToAboutMeDTO(AboutMe aboutMe)
        {
            AboutMeDTO aboutMeDTO = new()
            {
                Title = aboutMe.Title,
                Description = aboutMe.Description,
                banner = aboutMe.banner
            };
            return aboutMeDTO;
        }
        public static EducationDTO ToEducationDTO(Education education)
        {
            EducationDTO educationDTO = new()
            {
                Degree = education.Degree,
                Academy = education.Academy,
                Description = education.Description,
                EntryDate = education.EntryDate,
                Title = education.Title
            };
            return educationDTO;
        }
        public static ExperienceDTO ToExperirienceDTO(Experience experience)
        {
            ExperienceDTO experienceDTO = new()
            {
                Description = experience.Description,
                Name = experience.Name,
                JobTitle = experience.JobTitle,
                EntryDate = experience.EntryDate,
                Title = experience.Title
            };
            return experienceDTO;
        }
        public static SkillDTO ToSkillDTO(Skill skill)
        {
            SkillDTO skillDTO = new()
            {
                Title = skill.Title,
                Description = skill.Description
            };
            return skillDTO;
        }
        public static ProjectDTO ToProjectDTO(Project project)
        {
            ProjectDTO projectDTO = new()
            {
                Title = project.Title,
                Description = project.Description,
                URL = project.URL
            };
            return projectDTO;
        }
        public static ContactMe ToContactMe(ContactMeDTO contactMeDTO)
        {
            ContactMe contactMe = new()
            {
                Email = contactMeDTO.Email,
                Message = contactMeDTO.Message,
                Name = contactMeDTO.Name,
                Phone = contactMeDTO.Phone
            };
            return contactMe;
        }
    }
}
