using System.Collections.Generic;
using System.Linq;
using MyPersistance.Data;
using MyPersistance.Entities;

namespace MyPersistance.Repositories
{
    public class CustomerRepository
    {
        private readonly TemaS2MiercuriV2Context _context;

        public CustomerRepository(TemaS2MiercuriV2Context context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
    }
}
