using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTest
{
    static class Employee
    {
        private static string _name = "";
        public static string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private static string _email = "";
        public static string Email 
        { 
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        private static string _cpf = "";
        public static string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

        private static string _pw = "";
        public static string Password
        {
            get
            {
                return _pw;
            }
            set
            {
                _pw = value;
            }
        }

        private static string _bday = "";
        public static string Birthday
        {
            get
            {
                return _bday;
            }
            set
            {
                _bday = value;
            }
        }

        private static int _role = 0;
        public static int Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }
    }
}
