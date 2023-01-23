using CustomerForm.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerForm.Data
{
    public class SqlCustomerData : ICustommerData
    {
        public AppDbContext Db { get; }

        public SqlCustomerData(AppDbContext db)
        {
            Db = db;
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            Db.Add(newCustomer);
            return newCustomer;

        }

        public int Commit()
        {
            return Db.SaveChanges();
        }

        public Customer GetById(int id)
        {
            return Db.Custommers.Find(id);
        }

        public int GetCount()
        {
            return Db.Custommers.Count();
        }
    }
}
