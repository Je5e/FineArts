using System;
using System.Collections.Generic;

namespace FineArts.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } // Propiedad
        public string LastName { get; set; }
        public string Class { get; set; }

        public List<Student> Students { get; set; }
    }
}
