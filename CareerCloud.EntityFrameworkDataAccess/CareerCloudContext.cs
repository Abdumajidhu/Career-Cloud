using System.Configuration;
using System.Data.Entity;
using CareerCloud.Pocos;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public CareerCloudContext() : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantEducations)
                .WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantJobApplications)
                .WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantWorkHistories)
                .WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantResumes)
                .WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantSkills)
                .WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobEducations)
                .WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobSkills)
                .WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(c => c.CompanyDescriptions)
                .WithRequired(d => d.CompanyProfiles)
                .HasForeignKey(d => d.Company)
                .WillCascadeOnDelete(true);


            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(c => c.CompanyJobs)
                .WithRequired(d => d.CompanyProfiles)
                .HasForeignKey(d => d.Company)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobDescriptions)
                .WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(c => c.CompanyLocations)
                .WithRequired(d => d.CompanyProfiles)
                .HasForeignKey(d => d.Company)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.ApplicantJobApplications)
                .WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.SecurityLoginsLogs)
                .WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.SecurityLoginsRoles)
                .WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityRolePoco>()
                .HasMany(c => c.SecurityLoginsRoles)
                .WithRequired(d => d.SecurityRoles)
                .HasForeignKey(d => d.Role)
                .WillCascadeOnDelete(true);
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.ApplicantProfiles)
                .WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(c => c.ApplicantProfiles)
                .WithRequired(d => d.SystemCountryCodes)
                .HasForeignKey(d => d.Id)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(c => c.ApplicantWorkHistories)
                .WithRequired(d => d.SystemCountryCodes)
                .HasForeignKey(d => d.CountryCode)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(c => c.ApplicantProfiles)
                .WithRequired(d => d.SystemCountryCodes)
                .HasForeignKey(d => d.Country)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemLanguageCodePoco>()
                .HasMany(c => c.CompanyDescriptions)
                .WithRequired(d => d.SystemLanguageCodes)
                .HasForeignKey(d => d.LanguageId)
                .WillCascadeOnDelete(true);


            base.OnModelCreating(modelBuilder);
        }


        DbSet<ApplicantEducationPoco> ApplicantEducations { set; get; }
        DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { set; get; }
        DbSet<ApplicantProfilePoco> ApplicantProfiles { set; get; }
        DbSet<ApplicantResumePoco> ApplicantResumes { set; get; }
        DbSet<ApplicantSkillPoco> ApplicantSkills { set; get; }
        DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistoryPocos { set; get; }
        DbSet<CompanyDescriptionPoco> CompanyDescriptions { set; get; }
        DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { set; get; }
        DbSet<CompanyJobEducationPoco> CompanyJobEducations { set; get; }
        DbSet<CompanyJobPoco> CompanyJobs { set; get; }
        DbSet<CompanyJobSkillPoco> CompanyJobSkills { set; get; }
        DbSet<CompanyLocationPoco> CompanyLocations { set; get; }
        DbSet<CompanyProfilePoco> CompanyProfiles { set; get; }
        DbSet<SecurityLoginPoco> SecurityLogins { set; get; }
        DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { set; get; }
        DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { set; get; }
        DbSet<SecurityRolePoco> SecurityRoles { set; get; }
        DbSet<SystemCountryCodePoco> SystemCountryCodes { set; get; }
        DbSet<SystemLanguageCodePoco> SystemLanguageCodes { set; get; }
    }
}
