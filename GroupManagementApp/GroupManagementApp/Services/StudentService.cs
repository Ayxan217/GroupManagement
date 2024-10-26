using GroupManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GroupManagementApp.Services
{
    internal class StudentService:Student
    {

        public static List<Student> Students = new();
     

        public void CreateStudent()
        {
            
            Console.WriteLine("tehsil zemaneti:(var/yoxdur)");
            
           type: string insurance = Console.ReadLine().Trim().ToLower();
            if(insurance !="var" && insurance != "yoxdur")
            {
                Console.WriteLine("duzgun daxil edin");
                goto type;
            }
            else { 
                if(insurance == "var")
                {
                    Type = true; 
                }
               
            }
            Console.WriteLine("adi daxil edin: ");
        name: string name = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(name, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun ad daxil edin");
                goto name;
            }
            Console.WriteLine("soyadi daxil edin: ");
        surname: string surname = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(surname, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun soyad daxil edin");
                goto surname;
            }
     
            
            

                Student student = new Student()
                {
                    Name = name,
                    Surname = surname,
                    Type = Type
                };
               
                Students.Add(student);
            
                Console.WriteLine($"{name} {surname} yaradıldı ");



        }
       
        public void ShowStudents()
        {
            
            Console.WriteLine("Telebeler:");
            string type = Type ? "beli" : "xeyr";
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} zemantelidir? {type}");
            }




        }


    }
}
