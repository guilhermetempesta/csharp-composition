using System;

namespace Composition.Entity {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, DateTime birthDate) {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public override string ToString() {
            return
                this.Name
                + ", ("
                + this.BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + this.Email;
        }
    }
}