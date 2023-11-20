using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase {

    public class ClassUser {

        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateBirth { get; set; }
        public string Country { get; set; }


        public ClassUser(int id, string email, string firstName, string lastName, string dateBirth, string country) {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            DateBirth = dateBirth;
            Country = country;
        }


    }
}
