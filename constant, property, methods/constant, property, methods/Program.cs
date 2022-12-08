using System;

namespace constant__property__methods
{
    class Program
    {
        static void Main()
        {
            student.CollegeDetails();

            student S1 = new student(2234, "Rama", "bangalore", 998877);
            S1.Smailid = "@gmail.com";
            S1.Sage = 17;
            S1.scal(40, 40, 40);

            student.Clgphno = 12345;
            S1.DisplayStudentsinfo();

        }
    }

    class student
    {
        readonly ulong sid;
        readonly string sname;
        string sloc;
        byte sage;
        int sphono;
        string smailid;
        double stotalmarks;
        double savgmarks;
        string sresults;
        static string clgname;
        static string clgloc;
        static string clgmailid;
        static ulong clgphno;
        const short clgestd = 1998;
        const string clgestdperson = "Rama";

        internal student(ulong sid, string sname, string sloc, int sphono)
        {
            this.sid = sid;
            this.sname = sname;
            this.sloc = sloc;
            this.sphono = sphono;
        }

        internal string Smailid
        {
            get
            {
                return smailid;
            }
            set
            {
                smailid = value;
            }
        }

        internal byte Sage
        {
            set
            {
                while (value < 4 || value > 18)
                {
                    Console.WriteLine("Enter the age inbetween a and 18");
                    value = byte.Parse(Console.ReadLine());
                }
                sage = value;
            }
        }

        static student()
        {
            clgname = "High school";
            clgloc = "Mumbai";
            clgmailid = "@yahoo.com";
        }

        internal static ulong Clgphno
        {
            get
            {
                return clgphno;
            }
            set
            {
                clgphno = value;
            }
        }

        internal void scal(int M1, int M2, int M3)
        {
            stotalmarks = M1 + M2 + M3;

            savgmarks = stotalmarks / 3;

            if (M3 < 35 || M2 < 35 || M3 < 35)
            {
                sresults = "fail";
            }
            else if (savgmarks > 60)
            {
                sresults = "First Class";
            }
            else if (savgmarks > 50)
            {
                sresults = "Second Class";
            }
            else
            {
                sresults = "Third Class";
            }
        }

        internal void DisplayStudentsinfo()
        {
            Console.WriteLine("studen id is : {0}", sid);
            Console.WriteLine("student name is : {0}", sname);
            Console.WriteLine("student location is : {0}", sloc);
            Console.WriteLine("student age is : {0}", sage);
            Console.WriteLine("student phonenumber  is : {0}", sphono);
            Console.WriteLine("student mailid is : {0}", smailid);
            Console.WriteLine("student total marks is : {0}", stotalmarks);
            Console.WriteLine("student avg marks is : {0}", savgmarks);
            Console.WriteLine("student results is : {0}", sresults);
        }

        internal static void CollegeDetails()
        {
            Console.WriteLine("college name is : {0}", clgname);
            Console.WriteLine("college location is : {0}", clgloc);
            Console.WriteLine("college phone number is : {0}", clgphno);
            Console.WriteLine("college mail id is : {0}", clgmailid);
            Console.WriteLine("college estb name is : {0}", clgestdperson);
            Console.WriteLine("college year is : {0}", clgestd);
        }
    }
}
