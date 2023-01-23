using CustomerForm.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerForm.Data
{
    public interface ICustommerData
    {
        int GetCount();
        Customer AddCustomer(Customer newCustomer);
        Customer GetById(int id);
        int Commit();
    }
}
