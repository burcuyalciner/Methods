using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            string fname = "Mary";
            string lname = "Doe";
            //The normal implementation of the FullName method
            Console.WriteLine("The full name of the visitor is "+ FullName(fname,lname));
            // When we change the last name of the visitor in the method FullName2
            Console.WriteLine("The full name of the visitor is " + FullName2(fname, lname));
            Console.WriteLine("The name of the visitor is " + lname);
            // When we change the last name of the visitor in the method FullName3 by using ref keyword
            Console.WriteLine("The full name of the visitor is " + FullName3(fname, ref lname));
            Console.WriteLine("The name of the visitor is " + lname);

            string fname1 = "Andy";
            // When we change the last name of the visitor in the method FullName3 by using out keyword
            Console.WriteLine("The full name of the visitor is " + FullName4(fname, out lname));
            Console.WriteLine("The name of the visitor is " + lname);
            Console.WriteLine("The full name of the visitor is " + FullName4(fname1, out lname));
            Console.WriteLine("The name of the visitor is " + lname);

            //The normal implementation of the FullName method
            static string FullName(string fname, string lname)
            {
                string fullName = fname + " " + lname;
                return fullName;
            }

            //In this method we will change the last name of the visitor
            static string FullName2(string fname, string lname)
            {
                lname = "Jackson";
                string fullName = fname + " " + lname;
                return fullName;
            }

            /*In this method we will change the last name of the visitor in the method
             FullName3 by using ref keyword*/
            static string FullName3(string fname,ref string lname)
            {
                lname = "Jackson";
                string fullName = fname + " " + lname;
                return fullName;
            }


            /*In this method we will change the last name of the visitor in the method
             FullName3 by using out keyword*/
            static string FullName4(string fname, out string lname)
            {
                lname = "Turner";
                string fullName = fname + " " + lname;
                return fullName;
            }

        }

    }
}
