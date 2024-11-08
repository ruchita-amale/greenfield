using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    /// <summary>
    /// Every interface defined in program is called Propotype, contract, specification, etc
    /// </summary>
    public interface ICustomerService
    {
        List<Customer> GetAll();               //abstract method
        Customer Get(int id);
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
    }
}
