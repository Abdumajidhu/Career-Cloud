using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        [Column("Is_Company_Hidden")]
        public bool IsCompanyHidden { get; set; }
        [Timestamp]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyProfilePoco CompanyProfiles { set; get; }
        public virtual ICollection<CompanyJobEducationPoco> CompanyJobEducations { set; get; }
        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { set; get; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJobDescriptions { set; get; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { set; get; }
    }
}
