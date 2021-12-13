using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBA_7
{
    struct Student
    {
        int roll;
        string name;
        string gender;
        double mobile;
        public Student (int roll, string name, string gender, double mobile)
        {
            this.roll = roll;
            this.name = name;
            this.gender = gender;
            this.mobile = mobile;
        }

        public string Display()
        {
            return $"ROLL= {this.roll}\nNAME= {this.name}\nGENDER= {this.gender}\nMOBILE NO.= {this.mobile}";
        }
    }

    class StudentStructure
    {
        static void Main ()
        {
            String sname, sgen;
            Double smob;
            int sroll;

            Console.Write("ENTER ROLL = ");
            sroll = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER NAME = ");
            sname = Console.ReadLine();
            Console.Write("ENTER GENDER = ");
            sgen = Console.ReadLine();
            Console.Write("ENTER MOBILE NUMBER = ");
            smob = Convert.ToDouble(Console.ReadLine());
            Student ob = new Student(sroll, sname, sgen, smob);

            Console.WriteLine(ob.Display());
                      
            Console.ReadLine();
        }
        
            
    }
}
