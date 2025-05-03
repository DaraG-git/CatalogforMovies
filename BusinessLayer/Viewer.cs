using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Viewer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }

        public Viewer() { }
        public Viewer(string name, string email, string password, string phone, DateTime birthDate)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            BirthDate = birthDate;
        }
    }
}
