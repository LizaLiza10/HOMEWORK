using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
    internal class Student
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private string _birthday;
        private string _personalNumber;
        private int _id;
        private int _balance;
        private string _username;

       

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("First name cannot be empty");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Last name cannot be empty");
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("Invalid email address format");
                }
                else
                {
                    _email = value;
                }
            }
        }

        public string password
        {
            get { return _password; }
            set
            {
                if (value.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters");
                }
                else
                {
                    _password = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Phone number is too short");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        public string Birthday
        {
            get { return _birthday; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Birthday cannot be empty");
                }
                else
                {
                    _birthday = value;
                }
            }
        }

        public string PersonalNumber
        {
            get { return _personalNumber; }
            set
            {
                if (value.Length != 9)
                {
                    Console.WriteLine("Personal number must be exactly 11 digits");
                }
                else
                {
                    _personalNumber = value;
                }
            }
        }

        public int id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ID must be greater than 0");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public int balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public string username
        {
            get { return _username; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Username must be at least 4 characters");
                }
                else
                {
                    _username = value;
                }
            }







        }
    }
}
