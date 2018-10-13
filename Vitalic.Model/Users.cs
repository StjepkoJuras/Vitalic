using System;
using System.Collections.Generic;
using System.Text;

namespace Vitalic.Model
{
    public class Users
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GenderId { get; set; }
        public string Address { get; set; }
        public Guid CityId { get; set; }
        public Guid PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsActive { get; set; }
    }
}
