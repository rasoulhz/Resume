using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities
{
    public class PersonalInformation
    {
        public int Id { get; set; }    
        public string Name { get; set; } 
        public string JobTitle { get; set; }
        public string DescriptionTitle { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
    }
}
