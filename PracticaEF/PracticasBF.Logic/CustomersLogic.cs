using PracticaBF.Data;
using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public void add(Customers newEmployees)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Update(Customers employees)
        {
            throw new NotImplementedException();
        }
    }
}
