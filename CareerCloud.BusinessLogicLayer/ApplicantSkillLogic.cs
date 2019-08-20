using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantSkillLogic : BaseLogic<ApplicantSkillPoco>
    {
        public ApplicantSkillLogic(IDataRepository<ApplicantSkillPoco> repository) : base(repository)
        {

        }
        public override void Add(ApplicantSkillPoco[] pocos)
        {
            Verify(pocos);
            foreach (ApplicantSkillPoco poco in pocos)
            {

            }
            base.Add(pocos);
        }
        public override void Update(ApplicantSkillPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantSkillPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            string[] requiredExtendedPasswordChars = new string[] { "$", "*", "#", "_", "@" };

            foreach (var poco in pocos)
            {
                if (poco.StartMonth > 12)
                {
                    exceptions.Add(new ValidationException(101, "Start month cannot be greater than 12."));
                }
                else if (poco.EndMonth > 12)
                {
                    exceptions.Add(new ValidationException(102, $"End month cannot be greater than 12."));
                }
                else if (poco.StartYear < 1900)
                {
                    exceptions.Add(new ValidationException(103, $"Start Year cannot be earlier than 1900"));
                }
                else if (poco.EndYear < poco.StartYear)
                {
                    exceptions.Add(new ValidationException(104, $"End Year cannot be less than start year."));
                }                               
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

    }
}
