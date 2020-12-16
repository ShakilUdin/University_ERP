using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    abstract class Students
    {
        [Key]
        int id;
        string firstname;
        string lastname;
        string streetaddress;
        string city;
        int telephone;
       

        public int Id
        {
            get => id;
            set => id = value;
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

        public int Telephone
        {
            get => telephone;
            set => telephone = value;
        }
        public  Students()
        {}

        public Students(string fname, string lname, string address, string citi, int tel, int t1, int t2)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.streetaddress = address;
            this.city = citi;
            this.telephone = tel;
        }

        public abstract string ComputeGrade(int t1, int t2);

    }
}