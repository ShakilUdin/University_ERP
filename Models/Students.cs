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
        protected int test_1;
        protected int test_2;

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
            get => test_1;
            set => test_1 = value;
        }

       

        public virtual string ComputeGrade()
        {
            double result = (0.45 + test_1) + (0.55 + test_2);
            return result.ToString();
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
            this.test_1 = t1;
            this.test_2 = t2;
        }
    }
}
