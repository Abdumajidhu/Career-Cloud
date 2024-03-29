﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        [Column("Current_Salary")]
        public Decimal? CurrentSalary { get; set; }
        [Column("Current_Rate")]
        public Decimal? CurrentRate { get; set; }
        public string Currency { get; set; }
        [Column("Country_Code")]
        public string Country { get; set; }
        [Column("State_Province_Code")]
        public string Province { get; set; }
        [Column("Street_Address")]
        public string Street { get; set; }
        [Column("City_Town")]
        public string City { get; set; }
        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; }
        [Timestamp]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }


        public virtual SecurityLoginPoco SecurityLogins { set; get; }
        public virtual SystemCountryCodePoco SystemCountryCodes { set; get; }

        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { set; get; }
        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { set; get; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { set; get; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { set; get; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { set; get; }

    }
}
