﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public string LanguageId { get; set; }
        [Column("Company_Name")]
        public string CompanyName { get; set; }
        [Column("Company_Description")]
        public string CompanyDescription { get; set; }
        [Timestamp]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyProfilePoco CompanyProfiles { set; get; }
        public virtual SystemLanguageCodePoco SystemLanguageCodes { set; get; }
    }
}
