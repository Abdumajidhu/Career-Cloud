using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic
    {
        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository)
        {

        }

        public virtual void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            Update(pocos); 
        }

        public virtual void Add(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemCountryCodePoco poco in pocos)
            {
                
            }
            Add(pocos); 
        }
        public virtual void GetAll(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemCountryCodePoco poco in pocos)
            {

            }
            GetAll(pocos);
        }
        public void Delete(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            foreach (SystemCountryCodePoco poco in pocos)
            {

            }
            Delete(pocos);
        }
        public void Get(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            Delete(pocos);
        }
        protected virtual void Verify(SystemCountryCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();


            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Code))
                {
                    exceptions.Add(new ValidationException(900, "Code for SystemCountryCodeLogic is required."));
                }
                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(901, "Code for SystemCountryCodeLogic is required."));
                }


            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
