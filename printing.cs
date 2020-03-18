using System;
using System.Collections.Generic;
using System.Text;

namespace Enquiry_Form_Using_Properties
{
    class printing
    {

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("***********Enquiry Form Using Properties***********");

            Console.Write("Enter Name:");     //Name
            p.Name = Console.ReadLine();
            
            Console.Write("Enter Gender:");   //Gender
            p.Gender = Console.ReadLine();
            
            Console.Write("Enter Father Name:"); //FatherName
            p.Fathername = Console.ReadLine();
            
            Console.Write("Enter Mother Name:");   //MotherName
            p.Mothername = Console.ReadLine();

            Console.Write("Enter Contact Number:");  //ContactNumber
            p.Contact = Console.ReadLine();

            Console.Write("Enter Email Id:");    //Email Id
            p.Email = Console.ReadLine();

            Console.Write("Enter Course Name:"); //CourseName
            p.CourseName = Console.ReadLine();

            Console.Write("Enter Date Of Joining:"); //Date Of Joining
            p.DateofJoining = Console.ReadLine();

            Console.Write("\n");
            Console.WriteLine("**************Invoice**************");
            Console.WriteLine("Registration No:1\t Date: "+ DateTime.Now.ToString("dd MMMM yyyy hh:mm tt"));
            Console.WriteLine("Received with thanks from Mr." + p.Name);
            Console.WriteLine("The Sum of 'Rs.5000' in words 'Five Thousand Rupees Only /-'");



        }
    }
}
