using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]

    public class CompanyProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }        
        [Column("Company_Website")]
        public string CompanyWebsite { get; set; }
        [Column("Contact_Phone")]
        public string ContactPhone { get; set; }
        [Column("Contact_Name")]
        public string ContactName { get; set; }
        [Column("Company_Logo")]
        public Byte[] CompanyLogo { get; set; }

        [Timestamp]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }


        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { set; get; }
        //public virtual ICollection<ApplicantEducationPoco> CompanyEducations { set; get; }
        public virtual ICollection<CompanyJobPoco> CompanyJobs { set; get; }
        public virtual ICollection<CompanyLocationPoco> CompanyLocations { set; get; }
    }
}
