using System;

namespace Enquiry_Form_Using_Properties
{
    class Program
    {
        private string _name,_gender,_fathername,_mothername,_pincode,_contactno,_email,_coursename,_doj;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender= value; }
        }
        public string Fathername
        {
            get { return _fathername; }
            set { _fathername = value; }
        }

        public string Mothername
        {
            get { return _mothername; }
            set { _mothername = value; }
        }
         public string Contact
        {
            get { return _contactno; }
            set { _contactno = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string CourseName
        {
            get { return _coursename; }
            set { _coursename = value; }
        }
        public string DateofJoining
        {
            get { return _doj; }
            set { _doj = value; }
        }
    }
}
