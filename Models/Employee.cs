using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class Employee
    {
        private int id;
        [Key]
        private int empid;
        private string firstname;
        private string lastname;
        private string streetaddress;
        private string city;
        private string department;
        private int telephone;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Empid
        {
            get => empid;
            set => empid = value;
        }

        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        public string Streetaddress
        {
            get => streetaddress;
            set => streetaddress = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public int Telephone
        {
            get => telephone;
            set => telephone = value;
        }
    }
}
