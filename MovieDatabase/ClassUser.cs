using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase {

    public class ClassUser {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateBirth { get; set; }
        public string Country { get; set; }


        public ClassUser(int id, string email, string password, string firstName, string lastName, DateOnly dateBirth, string country) {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            DateBirth = dateBirth;
            Country = country;
        }


    }
}
