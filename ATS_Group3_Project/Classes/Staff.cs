using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS_Group3_Project
{
    public class Staff
    {
        [Key]
        private string staffID;
        private string firstName;
        private string lastName;
        private string workPhoneNo;
        private string homePhoneNo;
        private string workEmail;
        private string address1;
        private string address2;
        private string city;
        private string postcode;
        private double salary;
        private string role;
        private string password;

        // Constructor
        public Staff()
        {
            // Default constructor
        }

        public Staff(string staffID, string firstName, string lastName, string password)
        {
            this.staffID = staffID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }

        // Properties (Get/Set)
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string WorkPhoneNo
        {
            get { return workPhoneNo; }
            set { workPhoneNo = value; }
        }

        public string HomePhoneNo
        {
            get { return homePhoneNo; }
            set { homePhoneNo = value; }
        }

        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }


        public bool CheckPassword(string password)
        {
            return this.password == password;
        }
    }
}

