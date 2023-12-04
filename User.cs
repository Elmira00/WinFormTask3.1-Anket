using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTask3._1_Anket
{
    public  class User
    {
        public User(string name, string surname, string email, string phone, DateTime birthDate, string filePath)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
            FilePath = filePath;
        }
        public User()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string FilePath { get; set; }

        public override string ToString()
        {
            return $@"
            name : {Name},
            surname : {Surname},
            email : {Email},
            phone : {Phone}, 
            birthDate : {BirthDate}
            ";
        }
        
    }
}
