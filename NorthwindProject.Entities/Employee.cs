using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities
{
    // POCO: Plain Old CLR/C# Object
    // DTO: Data Tranfer Object
    // Entity: 
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string TitleOfCourtesy { get; set; }
        public string Title { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        // DDD (Domain Driven Design) yaklaşımında Entity nesnelerde aşağıdaki gibi
        // veri ile beraber DAVRANIŞLAR (Behaviour) bulunur
        //public void Hire(string title, DateTime date)
        //{

        //}

        //public void Fire()
        //{

        //}

        public byte[] Photo { get; set; }
    }
}
