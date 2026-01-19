using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class User
    {
        private int id;
        private string fullname;
        private string username;
        private string password;
        private string phoneNumber;
        private string email;
        private string usertype;


        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Usertype { get => usertype; set => usertype = value; }

        public User() 
        {

        }

        public User( string fullname,string username, string password, string phoneNumber, string email, string usertype)
        {
            this.Fullname = fullname;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Usertype = usertype;
        }

    }
}
