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
        protected int test1;
        protected int test2;

       

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

        protected int Test1
        {
            get => test1;
            set => test1 = value;
        }

        protected int Test2
        {
            get => test2;
            set => test2 = value;
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
            this.test1 = t1;
            this.test2 = t2;
        }

        public abstract string ComputeGrade();
    }
}