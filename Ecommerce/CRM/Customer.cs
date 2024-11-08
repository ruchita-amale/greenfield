using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    /// <summary>
    /// Pure Business Entity
    /// POCO Plain Old CLR Object
    /// ORM Object Relation mapping is concept in which the class have same attributes as database table -  to easy transfer object to table
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }           //auto property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

    }
}
