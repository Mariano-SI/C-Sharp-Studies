using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_MemoriaArraysEListas {
    internal class Student {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Student(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
