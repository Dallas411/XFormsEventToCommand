using System;
using System.Collections.Generic;
using System.Text;

namespace XFormsEventToCommand.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName => $"{Name} {Surname}";

    }
}
