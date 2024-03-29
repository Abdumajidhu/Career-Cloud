﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Resume { get; set; }
        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }

        public virtual ApplicantProfilePoco ApplicantProfiles { set; get; }
    }
}
