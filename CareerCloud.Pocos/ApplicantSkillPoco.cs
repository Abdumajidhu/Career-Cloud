﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    public class ApplicantSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Skill { get; set; }
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        [Column("Start_Month")]
        public Byte StartMonth { get; set; }
        [Column("Start_Year")]
        public Int32 StartYear { get; set; }
        [Column("End_Month")]
        public Byte EndMonth { get; set; }
        [Column("End_Year")]
        public Int32 EndYear { get; set; }
        [Timestamp]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual ApplicantProfilePoco ApplicantProfiles { set; get; }
    }
}
