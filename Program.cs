using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_practice
{
    internal class Program
    {
        abstract class person
        {
            public string firstName;
            public string lastName;
            public int age;
            public int phone;
            public abstract void getdetial();
        }
        class student : person
        {
            public int rollnumber;
            public int fees;
            public override void getdetial()
            {
                string name = this.firstName + " " + this.lastName;
                Console.WriteLine("student name :{0}",name);
                Console.WriteLine("student age:{0}", age);
                Console.WriteLine("student phone{0}", phone);
                Console.WriteLine("student rollnumber:{0}", rollnumber);
                Console.WriteLine("student fees:{0}", fees);
            }
        }
        class teacher : person
        {
              
            public string qualification;
            public int salary;
            public int id;
            public override void getdetial()
            {
                string name = this.firstName + " " + this.lastName;
                Console.WriteLine("teacher name :{0}", name);
                Console.WriteLine("teacher age:{0}", this.age);
                Console.WriteLine("teacher phone:{0}", this.phone);
                Console.WriteLine("teacher qualification:{0}", this.qualification);
                Console.WriteLine("teacher salary:{0}",this.salary);
                Console.WriteLine("teacher id :{0}", this.id);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\n.......WELCOME TO ALL DETAIL.....");
                student ans = new student();
                ans.firstName = "pradeep";
                ans.lastName = "kumar";
                ans.phone = 54567;
                ans.age = 20;
                ans.fees = 47678;
                ans.getdetial();
                Console.WriteLine("\n\n....................\n\n");
                teacher ans2 = new teacher();
                ans2.firstName = "shrinivash";
                ans2.lastName = "bharti";
                ans2.age = 24;
                ans2.phone = 65788;
                ans2.id = 2535;
                ans2.qualification = "BCA";
                ans2.salary = 23444;
                ans2.getdetial();
                Console.ReadLine();
            }
        }
    }
}


