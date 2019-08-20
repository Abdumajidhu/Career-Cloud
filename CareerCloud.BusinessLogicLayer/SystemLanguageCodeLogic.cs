using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic //: SystemCountryCodePoco
    {
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository)
        {

        }
        public virtual void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Update(pocos);
        }

        public virtual void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemLanguageCodePoco poco in pocos)
            {

            }
            Add(pocos);
        }
        public virtual void GetAll(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemLanguageCodePoco poco in pocos)
            {

            }
            GetAll(pocos);
        }
        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemLanguageCodePoco poco in pocos)
            {

            }

            Delete(pocos);
        }
        public void Get(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Delete(pocos);
        }
        protected virtual void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();


            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, "LanguageID for SystemLanguageCodeLogic is required."));
                }
                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001, "Name for SystemLanguageCodeLogic is required."));
                }
                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, "NativeName for SystemLanguageCodeLogic is required."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }        
    }
    
}
